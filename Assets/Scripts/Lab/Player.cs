using System;
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
            GameObject obj = Instantiate(Bullet, BulletSpawnPoint.position, Quaternion.identity);
            Banana banana = obj.GetComponent<Banana>();
            banana.Init(10, this);
            BulletSpawnTime = 0;

        }
    }

    void Start()
    {
<<<<<<< HEAD
        Init(50);
=======
        Init(100);
<<<<<<< Updated upstream
=======
<<<<<<< HEAD
>>>>>>> 7a015a539470fb8e6934d1e7b8e2a8d0dc590c6d
=======
>>>>>>> 7a015a539470fb8e6934d1e7b8e2a8d0dc590c6d
>>>>>>> Stashed changes
        BulletTimer = 1.0f;
        BulletSpawnTime = 0.0f;
    }
    
    public void Update()
    {
        Shoot();
    }

    private void FixedUpdate()
    {
        BulletSpawnTime += Time.fixedDeltaTime;
    }
}
