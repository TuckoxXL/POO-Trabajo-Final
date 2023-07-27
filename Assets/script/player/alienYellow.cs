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
    [SerializeField] 
    private int saltosExtrasRestantes;
    [SerializeField] 
    private int saltosExtras;
    [SerializeField]
    private float jumforce = 7;
    [SerializeField]
    private bool canjump;


    void Update()
    {
        Movilidad();
        Attack();
        Interact();
        Salto();
    }

    public void Salto()
    {
        if (Input.GetKeyDown(KeyCode.Space) && canjump)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, jumforce, 0);
            canjump = false;
        }

        if (canjump)
        {
            saltosExtrasRestantes = saltosExtras;
        }
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
