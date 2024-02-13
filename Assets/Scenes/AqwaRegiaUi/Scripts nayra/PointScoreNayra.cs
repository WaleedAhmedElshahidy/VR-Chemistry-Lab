
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointScoreNayra : MonoBehaviour
{
    public static PointScoreNayra instance;

    public Text scoreText;
    public Text highscore;

    public static int score;
    int HighScore = 4;

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreText.text = score.ToString() + "  POINTS ";
        highscore.text = "HighScore " + HighScore.ToString() + "  POINTS ";
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddPoint()
    {
        //score += 1;
        scoreText.text = score.ToString() + "  POINTS ";

    }
}
