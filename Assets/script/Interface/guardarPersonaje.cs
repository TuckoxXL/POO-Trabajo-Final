using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class guardarPersonaje : MonoBehaviour
{
    public GameObject menuPersonaje;
    public bool alienGreen;
    public bool alienRed;
    public bool alienYellow;
    public GameObject AlienGreen;
    public GameObject AlienRed;
    public GameObject AlienYellow;
    public CinemachineVirtualCamera virtualCamera;


    private void Start()
    {
        personajeGreen();
    }

    private void Update()
    {
        if (alienGreen == false && alienRed == false && alienYellow == false)
        {
            alienGreen = true;
        }

        alienGreen = PlayerPrefs.GetInt("alienGreenSelect") == 1;
        alienRed = PlayerPrefs.GetInt("alienRedSelect") == 1;
        alienYellow = PlayerPrefs.GetInt("alienYellowSelect") == 1;
    }

    public void personajeYellow()
    {
        alienYellow = true;
        alienRed = false;
        alienGreen = false;
        Guardar();
        virtualCamera.Follow = AlienYellow.transform;
    }

    public void personajeGreen()
    {
        alienGreen = true;
        alienRed = false;
        alienYellow = false;
        Guardar();
        virtualCamera.Follow = AlienGreen.transform;
    }

    public void personajeRed()
    {
        alienRed = true;
        alienYellow = false;
        alienGreen = false;
        Guardar();
        virtualCamera.Follow = AlienRed.transform;
    }

    public void Guardar()
    {
        PlayerPrefs.SetInt("alienGreenSelect", alienGreen ? 1 : 0);
        PlayerPrefs.SetInt("alienRedSelect", alienRed ? 1 : 0);
        PlayerPrefs.SetInt("alienYellowSelect", alienYellow ? 1 : 0);
        menuPersonaje.SetActive(false);
        Time.timeScale = 1;
    }


}
