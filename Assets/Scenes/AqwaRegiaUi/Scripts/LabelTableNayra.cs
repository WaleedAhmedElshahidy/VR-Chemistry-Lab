using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LabelTableNayra : MonoBehaviour
{
    public GameObject LabelrightFlask;
    public GameObject LabelleftFlask;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("flask"))
        {
            LabelrightFlask.SetActive(true);
        }
        if (other.gameObject.CompareTag("flask2"))
        {
            LabelleftFlask.SetActive(true);
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("flask"))
        {  
            LabelrightFlask.SetActive(false);
        }
        if (other.gameObject.CompareTag("flask2"))
        {  
            LabelleftFlask.SetActive(false);
        }
    }
}
