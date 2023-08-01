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
    private int saltosExtras =1;
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

        if (canjump)
        {
            saltosExtrasRestantes = saltosExtras;
        }
    }

    public void Salto()
    {
        if (Input.GetKeyDown(KeyCode.Space) && canjump == false)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, jumforce, 0);
            canjump = true;

            if (Input.GetButtonDown("Jump") && saltosExtrasRestantes > 0)
            {
                
                saltosExtrasRestantes--;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            canjump = false;
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
