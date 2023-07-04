using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cargarPersonaje : MonoBehaviour
{
    public GameObject menuPersonaje;
    public GameObject greenPersonaje;
    public GameObject redPersonaje;
    public GameObject yellowPersonaje;

    public bool alienGreen;
    public bool alienRed;
    public bool alienYellow;

    private void Update()
    {

        alienGreen = PlayerPrefs.GetInt("alienGreenSelect") == 1;
        alienRed = PlayerPrefs.GetInt("alienRedSelect") == 1;
        alienYellow = PlayerPrefs.GetInt("alienYellowSelect") == 1;

        if (alienGreen == true)
        {
            greenPersonaje.SetActive(true);
            redPersonaje.SetActive(false);
            yellowPersonaje.SetActive(false);
            
        }

        if (alienRed == true)
        {
            redPersonaje.SetActive(true);
            yellowPersonaje.SetActive(false);
            greenPersonaje.SetActive(false);
            

        }

        if (alienYellow == true)
        {
            yellowPersonaje.SetActive(true);
            redPersonaje.SetActive(false);
            greenPersonaje.SetActive(false);
            
        }
    }
}
