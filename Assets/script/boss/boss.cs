using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss : MonoBehaviour
{
    public float bossSpeed = 1f;

    public Transform player;
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, new Vector2(player.position.x, transform.position.y), bossSpeed * Time.deltaTime);
    }
}
