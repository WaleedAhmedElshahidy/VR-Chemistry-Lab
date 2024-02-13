using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using System.Data;
using Mono.Data.Sqlite;
using UnityEngine.SceneManagement;

public class GoToExp3 : MonoBehaviour
{
    public float duration;
    public Text timerText;
    public Text counterText;
    private int counter;
    private float startTime;
    private float timeRemaining;
    public GameObject timer;
    public List<string> sceneNames;
    public string ThirdEquation;

    void Start()
    {

        sceneNames = new List<string>();
        sceneNames.Add("Equation 1");
        sceneNames.Add("Equation 2 ");
        sceneNames.Add("Equation 3 ");
        ThirdEquation = sceneNames[2];
        Debug.Log(ThirdEquation);
    }
    public void LoadSelectionScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene("Equation 3");
        counter++;
        timer.SetActive(true);
        timeRemaining = duration;
        counterText.text = counter.ToString();
    }
}
