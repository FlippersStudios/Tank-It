using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public int id;
    public string username;
    public float health;
    public float maxHealth;
    public SpriteRenderer sprite;
    public GameObject head;

    public void Initialize(int _id, string _username)
    {
        id = _id;
        username = _username;
        health = maxHealth;
    }

    public void SetHealth(float _health)
    {
        health = _health;
        if (health <= 0)
        {
            PlayerDeath();
        }
    }

    public void PlayerDeath()
    {
        Debug.Log("Player died");
        sprite.enabled = false;
    }

    public void Respawn()
    {
        Debug.Log("Player respawned");
        sprite.enabled = true;
        SetHealth(maxHealth);
    }
}
