using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class keyManager : MonoBehaviour
{
    [SerializeField]
    private Text keyText;
    public static int keys = 1;

    void KeyText()
    {
        keyText.text = "KEY: " + keys + "/3";
    }
    private void OnEnable()
    {
        key.keyEvent += KeyText;
    }

    private void OnDisable()
    {
        key.keyEvent -= KeyText;
    }
}
