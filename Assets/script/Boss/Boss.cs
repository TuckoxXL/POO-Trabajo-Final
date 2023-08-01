using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public float bossSpeed = 1.0f;

    public Transform player;

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, new Vector2(player.position.x, transform.position.y), bossSpeed * Time.deltaTime);
    }
}
