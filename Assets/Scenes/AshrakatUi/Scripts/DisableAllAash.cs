using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableAllAash : MonoBehaviour
{
    public GameObject rightfalsk;
    public GameObject leftflask;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void disableall()
    {
        rightfalsk.GetComponent<OVRGrabbable>().enabled=false;
        leftflask.GetComponent<TitrationController>().enabled=false;
    }
}
