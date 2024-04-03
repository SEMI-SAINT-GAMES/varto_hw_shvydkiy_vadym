using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : Person
{
    [SerializeField] private int _experience;
    public int Experience => _experience;

    public override void ShowStat()
    {
        Debug.Log($"Person name is {Name}, person experience is {_experience}");
    }

    public override void TakeDamage(int damage)
    {
        Health -= damage;
        Debug.Log($"My name is {Name}: After hitting with force: {damage} | have: health {Health}");
        if (Health <= 0)
        {
            Die();
        }

        
    }
    
    
}
