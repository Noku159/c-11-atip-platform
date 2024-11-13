using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : Character
{
    private int damageHit;
    public int DamageHit
    {   get
        {
            return damageHit;
        }

        set
        {
            damageHit = value;
        }

    }
    [SerializeField] int damage;
    public int Damage { get { return damage; } set { damage = value; } }

    private void Start()
    {
        Behavior();
    }

    public abstract void Behavior();
    

}
