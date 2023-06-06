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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movilidad();
        Attack();
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
