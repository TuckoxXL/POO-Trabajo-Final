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

    private void Awake()
    {
        _player = FindObjectOfType<player>().transform;
    }


    void Update()
    {
        Vector2 enemyToPlayerVector = _player.position - transform.position;
        directionToPlayer = enemyToPlayerVector.normalized;

        if (enemyToPlayerVector.magnitude <= _playerAwarenessDistance)
        {
            awareOfPlayer = true;
        }
        else
        {
            awareOfPlayer = false;
        }
    }
}