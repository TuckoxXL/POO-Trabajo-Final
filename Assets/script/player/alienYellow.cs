using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alienYellow : player
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movilidad();
    }

    protected override void Movilidad()
    {
        base.Movilidad();
        float horizontalforce = Input.GetAxis("Horizontal") * Forcemultiplier;

        horizontalforce *= Time.deltaTime;
        transform.Translate(horizontalforce, 0, 0);
    }
}
