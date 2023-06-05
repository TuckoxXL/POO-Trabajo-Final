using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alienGreen : player
{
    private float jumforce;
    public bool canjump;

    // Start is called before the first frame update
    void Start()
    {

        jumforce = 7;
        canjump = false;
    }

    // Update is called once per frame
    void Update()
    {
        Movilidad();
        Salto();
       
    }

    public void Salto()
    {
        if (Input.GetKeyDown(KeyCode.Space) && canjump == false)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, jumforce, 0);
            canjump = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            canjump = false;
        }
    }
}
