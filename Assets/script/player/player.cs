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
    [SerializeField]
    protected bool interact;


    protected virtual void Movilidad()
    {

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

    protected virtual void Interact()
    {
        if (Input.GetKeyDown(KeyCode.E) && interact == false)
        {
            Debug.Log("toca la E");
            interact = true;
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "bandera")
        {
            Debug.Log("entraste");
        }
    }
}
