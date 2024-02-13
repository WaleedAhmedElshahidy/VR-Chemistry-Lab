using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using System.Data;
using Mono.Data.Sqlite;
using UnityEngine.SceneManagement;
using SQLiteDatabase;

public class BackToMenu : MonoBehaviour
{
    /*bool result;
    public float TimeToDB;
    public Text text;
    public SQLiteDB db = SQLiteDB.Instance;
    private int InsertAi;*/
    public GameObject part;
    private void Start()
    {
        /*
        result = db.ConnectToDefaultDatabase("students_data.db",true);
        Debug.Log(result);
        List<SQLiteDB.DB_DataPair> dataPairList = new List<SQLiteDB.DB_DataPair>();
        SQLiteDB.DB_DataPair data = new SQLiteDB.DB_DataPair();
        db.DBLocation = Application.persistentDataPath;
        Debug.Log(db.DBLocation);
        data.fieldName = "ID";
        data.value = "89478";
        dataPairList.Add(data);

        data.fieldName = "Date";
        data.value = "25";
        dataPairList.Add(data);
    
        data.fieldName = "Equation";
        data.value = "2";
        dataPairList.Add(data);

        data.fieldName = "Points";
        data.value = "12";
        dataPairList.Add(data);

        data.fieldName = "num.Rep";
        data.value = "30";
        dataPairList.Add(data);

        data.fieldName = "Time";
        data.value = "33:33";
        dataPairList.Add(data);
        
        InsertAi = db.Insert("AiModel", dataPairList);
        Debug.Log(InsertAi);
    }
    public void LoadSelectionScene()
    {
        AshrakatTimer.finish = true;
        TimeToDB = AshrakatTimer.timeRemaining;
        text.text = TimeToDB.ToString("00:00");

        //int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        //SceneManager.LoadScene("Choose Exp");*/
    }
    public void clicked()
    {
        part.SetActive(true);
    }
    private void Update()
    {

    }
    void OnEnable()
    {
        SQLiteEventListener.onError += OnError;
    }
    void OnDisable()
    {
        SQLiteEventListener.onError -= OnError;
    }
    void OnError(string err)
    {
        Debug.Log ("Error : "+err);
    }

}
