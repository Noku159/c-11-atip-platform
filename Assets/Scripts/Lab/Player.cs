using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character ,IShootable
{
    [field: SerializeField] public GameObject Bullet { get; set; }
    [field: SerializeField] public Transform BulletSpawnPoint { get; set; }
    [field: SerializeField] public float BulletSpawnTime { get; set; }
    [field: SerializeField] public float BulletTimer { get; set; }

    public void Shoot()
    {
        if (Input.GetButtonDown("Fire1") && BulletSpawnTime >= BulletTimer)
        {
            GameObject bulletObj = Instantiate(Bullet, BulletSpawnPoint.position, Quaternion.identity);
            Banana banana = bulletObj.GetComponent<Banana>();
            banana.Init ;
            WaitTime = 0;
        }
    }

    void Start()
    {
        Init(100);
        WaitTime = 0.0f;
        ReloadTime = 1.0f;
    }
    
    void Update()
    {
        Shoot();
    }

    private void FixedUpdate()
    {
        WaitTime += Time.fixedDeltaTime;
    }
    void OnHitWith(Enemy enemy)
    {
        TakeDamage(enemy.DamageHit);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Enemy enemy = collision.gameObject.GetComponent<Enemy>();
        if (enemy != null)
        { 
         OnHitWith(enemy);
         Debug.Log($"{this.name} hit with {enemy.name} dealing {enemy.DamageHit}damage.");
        }
    }
}
