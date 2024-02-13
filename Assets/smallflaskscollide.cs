using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smallflaskscollide : MonoBehaviour
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
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("flask"))
        {
            Debug.Log("collide!!!");
            Label.SetActive(true);
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("flask"))
        {
            Label.SetActive(false);
            Debug.Log("exit collide!!!");
        }
    }
}
