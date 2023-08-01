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
    private GameObject menuPersonaje;
    [SerializeField]
    private float jumforce = 7;
    [SerializeField]
    private bool canjump;


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
        if (collision.gameObject.CompareTag("Floor"))
        {
            canjump = false;
        }

        if (collision.gameObject.CompareTag("Enemy"))
        {
            SceneManager.LoadScene("derrota");
        }
    }
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
        if (Input.GetKeyDown(KeyCode.E))
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

        if (other.tag == "final")
        {
            SceneManager.LoadScene("Lvl2");
        }
    }
}
