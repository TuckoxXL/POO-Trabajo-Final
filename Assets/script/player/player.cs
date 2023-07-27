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
    protected float horizontalforce;
    [SerializeField]
    protected bool interact;
    [SerializeField]
    private GameObject menuPersonaje;
    [SerializeField]
    protected Transform ubicacionPlayer;
    public float distanceBeetween;

    public float distance;


    protected virtual void Movilidad()
    {

        horizontalforce = Input.GetAxis("Horizontal") * Forcemultiplier;

        horizontalforce *= Time.deltaTime;
        transform.Translate(horizontalforce, 0, 0);

        if (distance < distanceBeetween)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, ubicacionPlayer.transform.position, horizontalforce * Time.deltaTime);
        }
        
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
            menuPersonaje.SetActive(true);
            Time.timeScale = 0;
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
