using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diamond : MonoBehaviour
{
    public delegate void ScoreEvent();
    public static ScoreEvent scoreEvent;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            scoreEvent?.Invoke();
            Destroy(this.gameObject);
        }
    }
}
