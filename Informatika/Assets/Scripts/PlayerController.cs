using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public static PlayerController instance;
    public PlayerInput manager;

    bool w;
    bool a;
    bool s;
    bool d;
    bool space;
    bool b;

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
    private void FixedUpdate()
    {
        SendInputToServer();

        if (transform.rotation.eulerAngles.z == 180)
        {
            print("Rotation set to: 180");
        }
        if (transform.rotation.eulerAngles.z == -180)
        {
            print("Rotation set to: -180");
        }
        print(transform.rotation.eulerAngles.z);
        if (space)
        {
            print(transform.rotation.eulerAngles.z);
        }
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
            b
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
