using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    void Update()
    {
        Movement();
    }

    private void Movement()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(0.1f * -speed, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0.1f * speed, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0f, 0f, 0.1f * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0f,0f , 0.1f * -speed);
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "Enemy")
        {
            Destroy(collision.gameObject);
            Debug.Log("Enemy is dead");
        }
    }
}
