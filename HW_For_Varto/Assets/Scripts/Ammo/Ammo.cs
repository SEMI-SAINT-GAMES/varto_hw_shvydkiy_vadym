using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Ammo : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private int _damage;
    [SerializeField] private bool isRight;

    public int Damage => _damage;
    public float Speed => _speed;
    public void Move()
    {
        if (isRight)
            transform.Translate(0.1f * _speed, 0f, 0f);
        else
            transform.Translate(0.1f * -_speed, 0f, 0f);
    }

    private void OnCollisionEnter(Collision collider)
    {
        Person person = collider.gameObject.GetComponent<Person>();
        if (person)
        {
            person.TakeDamage(_damage);
            Destroy(gameObject);
        }
        
    }
}
