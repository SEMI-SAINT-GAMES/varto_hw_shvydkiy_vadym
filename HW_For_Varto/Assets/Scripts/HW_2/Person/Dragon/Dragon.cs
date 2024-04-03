using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dragon : Person
{ 
    public override void TakeDamage(int damage)
    {
        Health -= damage;
        Debug.Log($"I, the mighty dragon, have lost: {damage} hit points from a hunter's shot.");
        if (Health <= 0)
        {
            Die();
        }
    }
    
}
