using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flaskstay : MonoBehaviour
{
    public GameObject Label;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("flask"))
        {
            Label.SetActive(true);
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("flask"))
        {  
            Label.SetActive(false);
        }
    }
}
