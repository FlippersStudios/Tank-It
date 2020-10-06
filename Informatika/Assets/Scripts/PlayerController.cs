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

    private void Awake()
    {
        instance = this;
        manager = new PlayerInput();
        manager.Player.w.performed += ctx => w = ctx.ReadValueAsButton();
        manager.Player.a.performed += ctx => a = ctx.ReadValueAsButton();
        manager.Player.s.performed += ctx => s = ctx.ReadValueAsButton();
        manager.Player.d.performed += ctx => d = ctx.ReadValueAsButton();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        SendInputToServer();
        //print(w.ToString() + a.ToString()+ s.ToString() + d.ToString());
    }

    private void SendInputToServer()
    {
        bool[] _inputs = new bool[]
        {
            w,
            a,
            s,
            d
        };
        print(w.ToString() + "=W");
        print(a.ToString() + "=A");
        print(s.ToString() + "=S");
        print(d.ToString() + "=D");
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
