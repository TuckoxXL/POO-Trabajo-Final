using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Diamond;

public class key : MonoBehaviour
{
    public delegate void KeyEvent();
    public static KeyEvent keyEvent;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            keyEvent?.Invoke();
            keyManager.keys += 1;
            Destroy(gameObject, 0.1f);

        }
    }
}
