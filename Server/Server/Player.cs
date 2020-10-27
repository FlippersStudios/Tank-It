using System;
using System.Numerics;

namespace Server
{
    public class Player
    {
        public int id;
        public string username;

        public Vector3 position;
        public Vector3 rotation;

        float moveSpeed = 5f / Constants.TICKS_PER_SECOND;
        private float rotationIncrement = 10f;

        private bool[] inputs;
        
        private bool stateMove;

        public Player(int _id, string _username, Vector3 _spawnPosition)
        {
            id = _id;
            username = _username;
            position = _spawnPosition;
            inputs = new bool[6];
            stateMove = false;
        }

        public void Update()
        {
            Vector2 _inputDirection = Vector2.Zero;
            Vector3 _inputRotation = Vector3.Zero;
            float _direction = 1;

            if (inputs[5]) //B - button for changing rotation/movement
            {
                stateMove = !stateMove;
            }

            if (rotation.Z == 360 && rotationIncrement > 0)
            {
                rotation.Z = 0;
            }

            if (rotation.Z == 0 && rotationIncrement < 0)
            {
                rotation.Z = 360;
            }
            
            if (inputs[0])
            {
                _inputDirection.Y += 1; //W
                if (rotation.Z == 0.0f)
                {
                    return;
                }

                if (rotation.Z >= 180)
                {
                    _direction = 1f;
                }
                else
                {
                    _direction = -1f; 
                }
                _inputRotation.Z = rotationIncrement * _direction;
            }

            if (inputs[1])
            {
                _inputDirection.X -= 1; //A
                if (rotation.Z == 90)
                {
                    return;
                }
                if (rotation.Z >= 270 || rotation.Z >= 0 && rotation.Z < 90)
                {
                    _direction = 1f;
                }
                else if (rotation.Z < 270 && rotation.Z > 90)
                {
                    _direction = -1f;
                }
                _inputRotation.Z = rotationIncrement * _direction;
            }

            if (inputs[2])
            {
                _inputDirection.Y -= 1; //S
                if (rotation.Z == 180)
                {
                    return;
                }
                if (rotation.Z >= 0 && rotation.Z < 180)
                {
                    _direction = 1f;
                }
                else if (rotation.Z < 360 && rotation.Z > 180)
                {
                    _direction = -1f;
                }
                _inputRotation.Z = rotationIncrement * _direction;
            }

            if (inputs[3])
            {
                _inputDirection.X += 1; //D
                if (rotation.Z == 270)
                {
                    return;
                }
                if (rotation.Z >= 90 && rotation.Z < 270)
                {
                    _direction = 1f;
                }
                else if (rotation.Z < 90 || rotation.Z > 270)
                {
                    _direction = -1f;
                }
                _inputRotation.Z = rotationIncrement * _direction;
            }

            if (stateMove)
            {
                Move(_inputDirection);
            }
            else
            {
                Rotate(_inputRotation);
            }
        }

        private void Rotate(Vector3 _inputRotation)
        {
            rotation.Z += _inputRotation.Z;
            ServerSend.PlayerRotation(this);
        }

        private void Move(Vector2 _inputDirection)
        {
            Vector3 _forward = Vector3.Transform(new Vector3(0, 1, 0), Quaternion.Identity);
            Vector3 _right = Vector3.Normalize(Vector3.Cross(_forward, new Vector3(0, 0, 1)));

            Vector3 _moveDirection = _right * _inputDirection.X + _forward * _inputDirection.Y;

            position += _moveDirection * moveSpeed;

            ServerSend.PlayerPosition(this);
            //ServerSend.PlayerRotation(this);
        }

        public void SetInput(bool[] _inputs, Quaternion _rotation)
        {
            inputs = _inputs;
            //rotation = _rotation;
        }
    }
}