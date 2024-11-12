using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{

    [SerializeField]private int damage;
    public int Damage
    {  
        get
        { 
            return damage; 
        }
        set
        { 
           damage = value;
        }  
    }

    protected string ownerIshootable;
    public abstract void OnHitWith(Character character);
    public abstract void Move();
    public int GetShootDiection()
    {
        return 1;
    }
}
