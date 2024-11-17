using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    [SerializeField] private int health;
    public int Health
    {
        get
        {
            return health;
        }
        set
        {
            health = value;
        }

    }

    public virtual void Init(int newHealth)
    {
        health = newHealth;
        healtBar.SetMaxHealt(newHealth);
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }
    public Healtbar healtBar;
    public Animator anim;
    public Rigidbody2D rb;

    public bool Isdead()
    {
        if (Health <= 0)
        {
            Destroy(this.gameObject);
            return true;
        }
        else return false;

    }
    public void TakeDamage(int damage)
    {
        Health -= damage;

        Isdead();

        healtBar.SetHealth(health);
    }
}
