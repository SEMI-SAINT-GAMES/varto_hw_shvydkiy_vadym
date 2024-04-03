using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragonAmmo : Ammo
{
    [SerializeField] private float _rotationSpeed;
    void Update()
    {
        Move();
        Rotate();
    }

    private void Rotate()
    {
        transform.Rotate(0, 0, _rotationSpeed * Time.deltaTime);
    }
}
