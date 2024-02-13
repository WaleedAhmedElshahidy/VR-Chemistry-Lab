using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableAll1 : MonoBehaviour
{
    public GameObject ovrgrabmagnet;
    public GameObject magnetcontroll;
    public GameObject boxtitrationcontroll;
    public GameObject boxtitrationOVR;
    public GameObject imagetoststirrercontroller;
    public GameObject cylinderdropcontroll;
    public GameObject clyinderOvrgrab;
    public GameObject pippettedropperovr;
    public GameObject pippetteOVRgrabable;

    // Start is called before the first frame update
    void Start()
    {
        ovrgrabmagnet.GetComponent<OVRGrabbable>().enabled=false;
        magnetcontroll.GetComponent<MagnetController>().enabled=false;
        boxtitrationcontroll.GetComponent<TitrationController>().enabled=false;
        boxtitrationOVR.GetComponent<TitrationOVR>().enabled=false;
        imagetoststirrercontroller.GetComponent<StirrerController>().enabled=false;
        cylinderdropcontroll.GetComponent<DropController>().enabled=false;
        clyinderOvrgrab.GetComponent<OVRGrabbable>().enabled=false;
        pippettedropperovr.GetComponent<DropperOVR>().enabled=false;
        pippetteOVRgrabable.GetComponent<OVRGrabbable>().enabled=false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
