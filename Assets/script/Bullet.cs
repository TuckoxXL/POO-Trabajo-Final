using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody2D bullet;
    [SerializeField]
    private float shotForce;
    [SerializeField]
    private int bulletDamage = 10;

    void Start()
    {
        bullet = gameObject.GetComponent<Rigidbody2D>();
       
    }

    private void FixedUpdate()
    {
       bullet.AddForce(transform.right * shotForce, ForceMode2D.Impulse);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.GetComponent<ITakeDamage>() != null)
        {
            ITakeDamage col = collision.gameObject.GetComponent<ITakeDamage>();
                col.TakeDamage(bulletDamage);
        }
    }

}
