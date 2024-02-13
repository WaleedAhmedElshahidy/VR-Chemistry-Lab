using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GoToQuizYara : MonoBehaviour
{
    public List<string> sceneNames;
    public GameObject button;

    // Called when the button is clicked
    public void OnClick()
    {
        // Get a random scene name from the list
        int randomIndex = Random.Range(0, sceneNames.Count);
        string randomSceneName = sceneNames[randomIndex];

        // Load the scene
        
        SceneManager.LoadScene(randomSceneName);
    }

    // Called when the game starts
    public void Start()
    {
        sceneNames = new List<string>();
        sceneNames.Add("Equation 1 quiz");
        sceneNames.Add("Equation 2 quiz");
        sceneNames.Add("Equation 3 quiz");
    }
}