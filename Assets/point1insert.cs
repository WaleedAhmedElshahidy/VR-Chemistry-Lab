using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using System.Data;
using Mono.Data.Sqlite;
using UnityEngine.SceneManagement;
using SQLiteDatabase;

public class point1insert : MonoBehaviour
{
    public int points;
    public GameObject ash;
    private FinalAiModel scoress;
    //public GameObject myObject;
    // Start is called before the first frame update
    void Start()
    {
        points = 1;
        scoress = ash.GetComponent<FinalAiModel>();
        scoress.insertAiFunction();
        //when fail exp call this
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}