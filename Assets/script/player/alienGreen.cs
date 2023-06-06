using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alienGreen : player
{
    public float jumforce;
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
        Dead();
       Movilidad();
        Salto();
    }

    protected override void Movilidad()
    {
        base.Movilidad();

        float horizontalforce = Input.GetAxis("Horizontal") * Forcemultiplier;

        horizontalforce *= Time.deltaTime;
        transform.Translate(horizontalforce, 0, 0);
    }

    protected override void Dead()
    {
        base.Dead();
        if (vidaPlayer <= 0)
        {
            Debug.Log("sin vida");
        }
    }

    public void restarVida(int vidaRestar)
    {
        vidaPlayer -= vidaRestar;
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
