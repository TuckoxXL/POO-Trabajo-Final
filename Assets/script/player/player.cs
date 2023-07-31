using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
  
    protected virtual void Movilidad()
    {

        horizontalforce = Input.GetAxis("Horizontal") * Forcemultiplier;

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

        if (other.tag == "limit")
        {
            SceneManager.LoadScene("Derrota");
        }
    }
}
