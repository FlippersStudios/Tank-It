﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    public GameObject startMenu;
    public InputField usernameField;
    public InputField ipField;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.Log("Instance already exists. Destroying instance...");
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }

    public void ConnectToServer()
    {
        startMenu.SetActive(false);
        usernameField.interactable = false;
        ipField.interactable = false;
        Client.instance.ConnectToServer();
    }
}
