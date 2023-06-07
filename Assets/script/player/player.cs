using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour, ITakeDamage
{
    [SerializeField]
    protected float Forcemultiplier;
    [SerializeField]
    protected int vidaPlayer;
    [SerializeField]
    protected Animator PlayerAnimator;
    [SerializeField]
    protected float horizontalforce;
 
    protected virtual void Movilidad() {

    horizontalforce = Input.GetAxis("Horizontal") * Forcemultiplier;

    horizontalforce *= Time.deltaTime;
    transform.Translate(horizontalforce, 0, 0);


    }

    public virtual void Animator()
    {
        PlayerAnimator.SetFloat("movimientoX", horizontalforce * 100);

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
