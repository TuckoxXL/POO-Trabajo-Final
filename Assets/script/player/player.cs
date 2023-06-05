using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    private Rigidbody2D rb;
    private float Forcemultiplier;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Forcemultiplier = 10;
        
    }

    // Update is called once per frame
    void Update()
    {
        Movilidad();
    }

    public void Movilidad()
    {
        float horizontalforce = Input.GetAxis("Horizontal") * Forcemultiplier;

        horizontalforce *= Time.deltaTime;
        transform.Translate(horizontalforce, 0, 0);
    }
}
