using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class enemy : MonoBehaviour
{
    [SerializeField] private float velocity;
    public bool atacando;
    public float vision_range;
    public float rango_ataque;
    public GameObject range;
    public GameObject target;
    
    private void Start()
    {
        target = GameObject.Find("Player");
    }

    void Update()
    {
        Comportamiento();
        
    }

    public void Comportamiento()
    {
        if (Mathf.Abs(transform.position.x - target.transform.position.x) > vision_range && !atacando)
        {
            
        }
        else
        {
            if (Mathf.Abs(transform.position.x - target.transform.position.x) > rango_ataque && !atacando)
            {
                if (transform.position.x < target.transform.position.x)
                {
                    transform.Translate(Vector3.right * velocity * Time.deltaTime);
                    transform.rotation = Quaternion.Euler(0, 0, 0);
                }
                else
                {
                    transform.Translate(Vector3.right * velocity * Time.deltaTime);
                    transform.rotation = Quaternion.Euler(0, 180, 0);
                }
            }
            else
            {
                if (!atacando)
                {
                    if (transform.position.x < target.transform.position.x)
                    {
                        transform.rotation = Quaternion.Euler(0, 0, 0);
                    }
                    else
                    {
                        transform.rotation = Quaternion.Euler(0, 180, 0);
                    }
                }
            }
        }

    }
}
