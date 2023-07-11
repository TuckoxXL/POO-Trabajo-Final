using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAwareness : MonoBehaviour
{
    
    public bool awareOfPlayer { get; private set; }

    public Vector2 directionToPlayer { get; private set; }

    [SerializeField]
    private float _playerAwarenessDistance;

    private Transform _player;

    public Transform player;

    private float enemySpeed;

    private void Awake()
    {
        _player = GameObject.FindWithTag("Player").transform;
    }


    void Update()
    {
        Vector2 enemyToPlayerVector = _player.position - transform.position;
        directionToPlayer = enemyToPlayerVector.normalized;

        if (enemyToPlayerVector.magnitude <= _playerAwarenessDistance)
        {
            awareOfPlayer = true;

            if (awareOfPlayer == true)
            {
                transform.position = Vector2.MoveTowards(transform.position, new Vector2(player.position.x, transform.position.y), enemySpeed * Time.deltaTime);
            }
        }
        else
        {
            awareOfPlayer = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("hola");
            
        }
    }
}
