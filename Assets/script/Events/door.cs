using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
    public int keys;

    private void Update()
    {
        keys = keyManager.keys;
        if (keyManager.keys >= 4)
        {
            Destroy(gameObject,0.1f);
        }
    }
}
