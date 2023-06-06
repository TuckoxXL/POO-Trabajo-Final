using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alienGreen : player
{
    [SerializeField]
    private float jumforce = 7;
    [SerializeField]
    private bool canjump;

    void Update()
    {
        Movilidad();
        Salto();
    }
 
    public void Salto()
    {
        if (Input.GetKeyDown(KeyCode.Space) && canjump)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, jumforce, 0);
            canjump = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            canjump = true;
        }
    }
}
