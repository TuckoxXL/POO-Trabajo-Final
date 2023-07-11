using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{

    public float velocidadEnemigo = 1f;

    public Transform player;

    public float vision_range;

    public GameObject range;


    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, new Vector2(player.position.x, transform.position.y), velocidadEnemigo * Time.deltaTime);
    }
}
