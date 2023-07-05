using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alienYellow : player,ICanAttack
{
    public GameObject bullet;
    public float shotForce;
    public float shotRate;
    public float shotTime;
    public Transform spawnBullet;

    void Update()
    {
        Movilidad();
        Attack();
        //Animator();
        Interact();
    }

    public void Attack()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (Time.time > shotTime)
            {
                GameObject newbullet;
                newbullet = Instantiate(bullet, spawnBullet.position, spawnBullet.rotation);
                newbullet.GetComponent<Rigidbody2D>().AddForce(spawnBullet.forward * shotForce);
                shotTime = Time.time + shotRate;
                Destroy(newbullet, 1);
            }
        }
    }
}
