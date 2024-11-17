using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ant : Enemy
{

    [SerializeField] private Vector2 velocity;
    [SerializeField] private Transform[] movePoints;
    public Player player;

    private void Start()
    {
<<<<<<< Updated upstream
        Init(100);
        DamageHit = 2;
        player = GameObject.FindAnyObjectByType<Player>();
=======
<<<<<<< HEAD
<<<<<<< HEAD
        Behavior();
=======
        Init(100);
        DamageHit = 2;
        player = GameObject.FindAnyObjectByType<Player>();
>>>>>>> 7a015a539470fb8e6934d1e7b8e2a8d0dc590c6d
=======
        Init(100);
        DamageHit = 2;
        player = GameObject.FindAnyObjectByType<Player>();
>>>>>>> 7a015a539470fb8e6934d1e7b8e2a8d0dc590c6d
>>>>>>> Stashed changes
    }

    //public void Init(int newHealth)
    //{
       // Health = newHealth;
    //}

    private void FixedUpdate()
    {
        Behavior();
    }

    public override void Behavior()
    {

        rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);

        if (rb.position.x <= movePoints[0].position.x && velocity.x < 0)
        {
            FlipCharacter();
        }
        else if (rb.position.x >= movePoints[1].position.x && velocity.x > 0)
        {
            FlipCharacter();
        }
    }

    private void FlipCharacter()
    {
        velocity *= -1;

        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }

<<<<<<< Updated upstream
    
=======
<<<<<<< HEAD
<<<<<<< HEAD
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
         Character playercharacter = collision.gameObject.GetComponent<Character>();
         playercharacter.TakeDamage(2);

        }
  
    }
=======
    
>>>>>>> 7a015a539470fb8e6934d1e7b8e2a8d0dc590c6d
=======
    
>>>>>>> 7a015a539470fb8e6934d1e7b8e2a8d0dc590c6d
>>>>>>> Stashed changes

}
