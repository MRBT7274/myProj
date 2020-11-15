using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallScrypt : MonoBehaviour
{ public GameObject boomy;
    public int health;
    public void takeDamage()
    {
        health--;
        if (health <= 0)
        {
            Destroy(gameObject);
            GameObject t= Instantiate(boomy, transform.position, transform. rotation);
            Destroy(t, 2);
        }
    }
}
