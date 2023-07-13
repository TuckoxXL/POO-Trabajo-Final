using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreManager : MonoBehaviour
{
    [SerializeField]
    private Text scoreText;
    private int counter;

    void ScoreText()
    {
        counter++;
        scoreText.text = "SCORE: " + counter;
    }

    private void OnEnable()
    {
        Diamond.scoreEvent += ScoreText;
    }

    private void OnDisable()
    {
        Diamond.scoreEvent -= ScoreText;
    }
}
