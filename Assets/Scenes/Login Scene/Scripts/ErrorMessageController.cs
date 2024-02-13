using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ErrorMessageController : MonoBehaviour
{
    public GameObject ErrorMessage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ErrorOff()
    {
        ErrorMessage.SetActive(false);
    }
    public void ErrorOn()
    {
        ErrorMessage.SetActive(true);
    }
    
}
