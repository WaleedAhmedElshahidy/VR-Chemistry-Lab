using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using System.Data;
using Mono.Data.Sqlite;
using UnityEngine.SceneManagement;

public class GoToExp2 : MonoBehaviour
{
    public float duration;
    public Text timerText;
    public Text counterText;
    private int counter;
    private float startTime;
    private float timeRemaining;
    public GameObject timer;
    public void LoadSelectionScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene("Equation 2");
        counter++;
        timer.SetActive(true);
        timeRemaining = duration;
        counterText.text = counter.ToString();


    }
}
