using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using System.Data;
using Mono.Data.Sqlite;
using UnityEngine.SceneManagement;
using SQLiteDatabase;

public class FinalAiModel : MonoBehaviour { 
    bool result;
    public SQLiteDB db = SQLiteDB.Instance;
    public GameObject scoreashss;
    private point1insert score;
    public GameObject finalshosho;
    private point3insert shosho;
    public GameObject equationname;
    private GoToExp3 equation3;
    private string numequation;
    private int ash;
    private int shoshoo;
    private int insertAi;
    private int Updaterow;
    public float DataTime;
    private void Start()
    {

    }
    // Update is called once per frame
    void Update()
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
        Debug.Log("Error : " + err);
    }
    public void insertAiFunction()
    {
        score = scoreashss.GetComponent<point1insert>();
        ash = score.points;

        shosho =finalshosho.GetComponent<point3insert>();
        shoshoo = shosho.points;

       


            equation3 = equationname.GetComponent<GoToExp3>();
            numequation = equation3.ThirdEquation;

         
       
            result = db.ConnectToDefaultDatabase("AllStudent.db", false);
            Debug.Log(result);
            List<SQLiteDB.DB_DataPair> dataPairList = new List<SQLiteDB.DB_DataPair>();
            SQLiteDB.DB_DataPair data = new SQLiteDB.DB_DataPair();




            data.fieldName = "ID";
            data.value = "1222";
            dataPairList.Add(data);


            Debug.Log("Yara");
            data.fieldName = "Equation1";
            data.value = numequation.ToString();
            dataPairList.Add(data);

            data.fieldName = "Points1";
            data.value = shoshoo.ToString();
            dataPairList.Add(data);


            data.fieldName = "Date1";
            data.value = "29/13/2029";
            dataPairList.Add(data);

            data.fieldName = "numRep";
            data.value = "300111";
            dataPairList.Add(data);
            DataTime = fillControllerAsh.time;
            data.fieldName = "Time1";
            data.value = DataTime.ToString();
            dataPairList.Add(data);

            insertAi = db.Insert("Ai_Model1", dataPairList);
            Debug.Log(insertAi);
    }
}
