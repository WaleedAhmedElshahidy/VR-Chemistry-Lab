using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using SQLiteDatabase;


public class getinputs : MonoBehaviour
{
    public InputField usernameInput;
    public InputField passwordInput;
    public SQLiteDB db = SQLiteDB.Instance;
    public Animator Error;
    public GameObject ErrorMessage;
    bool result;
    static public string inputID;
    // Start is called before the first frame update
    void Start()
    {
        result = db.ConnectToDefaultDatabase("students_data.db",true);
        Debug.Log(result);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void login()
    {
        DBReader reader = db.GetAllData("Students_Data");
        while(reader != null && reader.Read())
        {
            if(reader.GetStringValue("ID") == usernameInput.text.ToString() && reader.GetStringValue("Password") == passwordInput.text.ToString()) 
            {
                inputID = usernameInput.text.ToString();
                SceneManager.LoadScene("menu");
            }else{
                Error.SetTrigger("ErrorUp");
                ErrorMessage.SetActive(true);
            }
        }
    }

}