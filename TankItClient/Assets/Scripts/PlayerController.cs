using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public Transform transfrom;

    public static PlayerController instance;
    public PlayerInput manager;

    public float rotateSpeed = 10f;
    private float direction;
    private float rotationIncrement = 10f;
    public Rigidbody2D body;

    bool w;
    bool a;
    bool s;
    bool d;
    bool space;
    bool b;
    bool bActiveSelf;

    private void Awake()
    {
        instance = this;
        manager = new PlayerInput();
        manager.Player.w.performed += ctx => w = ctx.ReadValueAsButton();
        manager.Player.a.performed += ctx => a = ctx.ReadValueAsButton();
        manager.Player.s.performed += ctx => s = ctx.ReadValueAsButton();
        manager.Player.d.performed += ctx => d = ctx.ReadValueAsButton();
        manager.Player.space.performed += ctx => space = ctx.ReadValueAsButton();
        manager.Player.b.performed += ctx => b = ctx.ReadValueAsButton();
    }

    // Update is called once per frame
    private void Update()
    {
        if (space)
        {
            ClientSend.PlayerShoot(transfrom.forward);
        }

        if (b)
        {
            bActiveSelf = !bActiveSelf;
        }
    }

    private void FixedUpdate()
    {
        TestOrientation();
        SendInputToServer();
    }

    private void TestOrientation()
    {
        if (bActiveSelf == false)
        {
            float inputRotation = 0;
            if (w)
            {
                if (body.transform.rotation.eulerAngles.z == 0.0f)
                {
                    SendInputToServer();
                    return;
                }

                if (body.transform.rotation.eulerAngles.z >= 180)
                {
                    direction = 1f;
                }
                else
                {
                    direction = -1f;
                }

                inputRotation = rotationIncrement * direction;
                Rotate(inputRotation);
            }

            if (a)
            {
                if (body.transform.rotation.eulerAngles.z == 90)
                {
                    SendInputToServer();
                    return;
                }

                if (body.transform.rotation.eulerAngles.z >= 270 || body.transform.rotation.eulerAngles.z >= 0 &&
                    body.transform.rotation.eulerAngles.z < 90)
                {
                    direction = 1f;
                }
                else if (body.transform.rotation.eulerAngles.z < 270 && body.transform.rotation.eulerAngles.z > 90)
                {
                    direction = -1f;
                }

                inputRotation = rotationIncrement * direction;
                Rotate(inputRotation);
            }

            if (s)
            {
                if (body.transform.rotation.eulerAngles.z == 180)
                {
                    SendInputToServer();
                    return;
                }

                if (body.transform.rotation.eulerAngles.z >= 0 && body.transform.rotation.eulerAngles.z < 180)
                {
                    direction = 1f;
                }
                else if (body.transform.rotation.eulerAngles.z < 360 && body.transform.rotation.eulerAngles.z > 180)
                {
                    direction = -1f;
                }

                inputRotation = rotationIncrement * direction;
                Rotate(inputRotation);
            }

            if (d)
            {
                if (body.transform.rotation.eulerAngles.z == 270)
                {
                    SendInputToServer();
                    return;
                }

                if (body.transform.rotation.eulerAngles.z >= 90 && body.transform.rotation.eulerAngles.z < 270)
                {
                    direction = 1f;
                }
                else if (body.transform.rotation.eulerAngles.z < 90 || body.transform.rotation.eulerAngles.z > 270)
                {
                    direction = -1f;
                }

                inputRotation = rotationIncrement * direction;
                Rotate(inputRotation);
            }
        }
        else
        {
            SendInputToServer();
        }
    }

    private void Rotate(float _inputRotation)
    {
        body.transform.Rotate(new Vector3(0, 0, 1), _inputRotation * rotateSpeed * Time.deltaTime);
    }

    private void SendInputToServer()
    {
        var _inputs = new bool[]
        {
            w,
            a,
            s,
            d,
            space,
            bActiveSelf //TODO: change to local bool and handle timing from here
        };

        ClientSend.PlayerMovement(_inputs);
    }


    private void OnEnable()
    {
        manager.Enable();
    }

    private void OnDisable()
    {
        manager.Disable();
    }
}