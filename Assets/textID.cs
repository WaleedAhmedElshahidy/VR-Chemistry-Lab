using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textID : MonoBehaviour
{
    public Text text;
    private string ID;
    // Start is called before the first frame update
    void Start()
    {
        ID = getinputs.inputID;
        text.text = ID;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
