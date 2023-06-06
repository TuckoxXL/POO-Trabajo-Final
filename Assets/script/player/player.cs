using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour, ITakeDamage
{
    [SerializeField]
    protected float Forcemultiplier;
    [SerializeField]
    protected int vidaPlayer;
 
    protected virtual void Movilidad() {

    float horizontalforce = Input.GetAxis("Horizontal") * Forcemultiplier;

    horizontalforce *= Time.deltaTime;
    transform.Translate(horizontalforce, 0, 0);


    }
    
    public virtual void TakeDamage(int damage)
    {
        vidaPlayer -= damage;
        if (vidaPlayer <= 0)
        {
            Debug.Log("sin vida");
        }
    }
}
