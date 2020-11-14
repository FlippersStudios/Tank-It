using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int id;
    public string username;
    
    public Vector3 rotation;

    float moveSpeed = 5f / Constants.TICKS_PER_SECOND;
    private float rotationIncrement = 10f;

    private bool[] inputs;
    private bool stateMove;

    public void Initialize(int _id, string _username)
    {
        id = _id;
        username = _username;
        inputs = new bool[6];
        stateMove = true;
    }

    public void FixedUpdate()
    {
        Vector2 inputDirection = Vector2.zero;
        Vector3 inputRotation = Vector3.zero;
        float direction = 1;

        if (inputs[5]) //B - button for changing rotation/movement
        {
            stateMove = !stateMove;
        }

        if (rotation.z == 360 && rotationIncrement > 0)
        {
            rotation.z = 0;
        }

        if (rotation.z == 0 && rotationIncrement < 0)
        {
            rotation.z = 360;
        }

        if (inputs[0])
        {
            inputDirection.y += 1; //W
            if (rotation.z == 0.0f)
            {
                return;
            }

            if (rotation.z >= 180)
            {
                direction = 1f;
            }
            else
            {
                direction = -1f;
            }

            inputRotation.z = rotationIncrement * direction;
        }

        if (inputs[1])
        {
            inputDirection.x -= 1; //A
            if (rotation.z == 90)
            {
                return;
            }

            if (rotation.z >= 270 || rotation.z >= 0 && rotation.z < 90)
            {
                direction = 1f;
            }
            else if (rotation.z < 270 && rotation.z > 90)
            {
                direction = -1f;
            }

            inputRotation.z = rotationIncrement * direction;
        }

        if (inputs[2])
        {
            inputDirection.y -= 1; //S
            if (rotation.z == 180)
            {
                return;
            }

            if (rotation.z >= 0 && rotation.z < 180)
            {
                direction = 1f;
            }
            else if (rotation.z < 360 && rotation.z > 180)
            {
                direction = -1f;
            }

            inputRotation.z = rotationIncrement * direction;
        }

        if (inputs[3])
        {
            inputDirection.x += 1; //D
            if (rotation.z == 270)
            {
                return;
            }

            if (rotation.z >= 90 && rotation.z < 270)
            {
                direction = 1f;
            }
            else if (rotation.z < 90 || rotation.z > 270)
            {
                direction = -1f;
            }

            inputRotation.z = rotationIncrement * direction;
        }

        if (stateMove)
        {
            Move(inputDirection);
        }
        else
        {
            Rotate(inputRotation);
        }
    }

    private void Rotate(Vector3 _inputRotation)
    {
        rotation.z += _inputRotation.z;
        
        ServerSend.PlayerRotation(this);
    }

    private void Move(Vector2 _inputDirection)
    {
        Vector3 _moveDirection = transform.right * _inputDirection.x + transform.up * _inputDirection.y;

        transform.position += _moveDirection * moveSpeed;

        ServerSend.PlayerPosition(this);
    }

    public void SetInput(bool[] _inputs)
    {
        inputs = _inputs;
    }
}