using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class Rock : Weapon
{

    Rigidbody2D rb2d;
    bool hasHit;
    Vector2 force;

     void Start()
     {
        Damage = 2;
        rb2d = GetComponent<Rigidbody2D>();
        force = new Vector2(GetShootDirection() * 100, 500);
        hasHit = false;
        Move();

     }
    

    public override void Move()
    {
        rb2d.AddForce(force);  
    }
    


    public override void OnHitWith(Character character)
    {

        if (character is Player)
        {
            hasHit = true;
            character.TakeDamage(this.Damage);
            Destroy(this.gameObject);
        }

    }

}