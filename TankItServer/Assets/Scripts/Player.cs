using System.Collections;
using System.Collections.Generic;
using TMPro.SpriteAssetUtilities;
using Unity.Mathematics;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int id;
    public string username;

    public Rigidbody2D body;
    public Rigidbody2D head;
    public Transform shootOrigin;
    public float health;
    public float maxHealth = 100f;


    float moveSpeed = 5f / Constants.TICKS_PER_SECOND;
    float rotateSpeed = 5f / Constants.TICKS_PER_SECOND;
    private float rotationIncrement = 10f;

    private bool[] inputs;
    private bool stateMove;

    public void Initialize(int _id, string _username)
    {
        id = _id;
        username = _username;
        health = maxHealth;
        inputs = new bool[6];
        stateMove = true;
    }
    

    public void FixedUpdate()
    {
        stateMove = inputs[5];
        Vector2 inputDirection = Vector2.zero;
        float inputRotation = 0;
        float direction = 1;

        if (inputs[0])
        {
            inputDirection.y += 1; //W

            if (head.transform.rotation.eulerAngles.z == 0.0f)
            {
                return;
            }

            if (head.transform.rotation.eulerAngles.z >= 180)
            {
                direction = 1f;
            }
            else
            {
                direction = -1f;
            }

            inputRotation = rotationIncrement * direction;
        }

        if (inputs[1])
        {
            inputDirection.x -= 1; //A;
            
            if (head.transform.rotation.eulerAngles.z == 90)
            {
                return;
            }

            if (head.transform.rotation.eulerAngles.z >= 270 || head.transform.rotation.eulerAngles.z >= 0 && head.transform.rotation.eulerAngles.z < 90)
            {
                direction = 1f;
            }
            else if (head.transform.rotation.eulerAngles.z < 270 && head.transform.rotation.eulerAngles.z > 90)
            {
                direction = -1f;
            }

            inputRotation = rotationIncrement * direction;
        }

        if (inputs[2])
        {
            inputDirection.y -= 1; //S
            if (head.transform.rotation.eulerAngles.z == 180)
            {
                return;
            }

            if (head.transform.rotation.eulerAngles.z >= 0 && head.transform.rotation.eulerAngles.z < 180)
            {
                direction = 1f;
            }
            else if (head.transform.rotation.eulerAngles.z < 360 && head.transform.rotation.eulerAngles.z > 180)
            {
                direction = -1f;
            }

            inputRotation = rotationIncrement * direction;
        }

        if (inputs[3])
        {
            inputDirection.x += 1; //D
            
            if (head.transform.rotation.eulerAngles.z == 270)
            {
                return;
            }

            if (head.transform.rotation.eulerAngles.z >= 90 && head.transform.rotation.eulerAngles.z < 270)
            {
                direction = 1f;
            }
            else if (head.transform.rotation.eulerAngles.z < 90 || head.transform.rotation.eulerAngles.z > 270)
            {
                direction = -1f;
            }

            inputRotation = rotationIncrement * direction;
        }

        if (!stateMove)
        {
            Move(inputDirection);
        }
        else
        {
            Rotate(inputRotation);
        }
    }

    private void Rotate(float _inputRotation)
    {
        head.transform.Rotate(new Vector3(0, 0, 1), _inputRotation * rotateSpeed);

        ServerSend.PlayerRotation(this);
    }

    private void Move(Vector2 _inputDirection)
    {
        body.MovePosition(body.position + _inputDirection * moveSpeed);

        ServerSend.PlayerPosition(this);
    }

    public void SetInput(bool[] _inputs)
    {
        inputs = _inputs;
    }

    public void Shoot(Vector3 _viewDirection)
    {
        if (Physics.Raycast(shootOrigin.position, _viewDirection, out RaycastHit _hit, 25f))
        {
            Debug.Log(_hit.collider);
            if (_hit.collider.CompareTag("Player"))
            {
                //demage player
                _hit.collider.GetComponent<Player>().TakeDemage(50f);
            }
        }
    }

    public void TakeDemage(float _deamage)
    {
        if (health <= 0f)
        {
            return;
        }

        health -= _deamage;
        if (health <= 0f)
        {
            health = 0;
            //todo: disable rigidbody
            transform.position = new Vector3(0, 8, 0);
            ServerSend.PlayerPosition(this);
            StartCoroutine(Respawn());
        }
        
        ServerSend.PlayerHealth(this);
    }

    private IEnumerator Respawn()
    {
        yield return new WaitForSeconds(10f);

        health = maxHealth;
        ServerSend.PlayerRespawned(this);
    }
}