using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AshrakatTimer : MonoBehaviour
{
    static public float timeRemaining;
    static public bool finish;
    public void Start()
    {
        finish = false;
        timeRemaining = 0.0f;
    }
    private void Update()
    {
        if(finish==false)
        {
            timeRemaining += Time.deltaTime * 60;
        }
        //timeRemaining = timeRemaining;
    }
}
