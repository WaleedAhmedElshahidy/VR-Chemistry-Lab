using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tubecollide : MonoBehaviour
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
        if (other.gameObject.CompareTag("Tube"))
        {
            Debug.Log("collide!!!");
            Label.SetActive(true);
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Tube"))
        {
            Label.SetActive(false);
            Debug.Log("exit collide!!!");
        }
    }
}
