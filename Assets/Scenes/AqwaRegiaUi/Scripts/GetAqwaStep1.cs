using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetAqwaStep1 : MonoBehaviour
{
    public Animator Step1Down;
    public Animator FullDown;
    public GameObject typestep1;
    public GameObject audioStep1;
    public GameObject Grabrightflask;
    public GameObject Grableftflask;
    public GameObject Grabcenterflask;
    public GameObject Button;
    public GameObject shadowButton;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("button",30.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Step1()
    {
        Grabrightflask.GetComponent<OVRGrabbable>().enabled = true;
        Grabrightflask.GetComponent<OVRGrabbable>().Awake();

        Grableftflask.GetComponent<OVRGrabbable>().enabled = true;
        Grableftflask.GetComponent<OVRGrabbable>().Awake();
        
        Grabcenterflask.GetComponent<OVRGrabbable>().enabled = true;
        Grabcenterflask.GetComponent<OVRGrabbable>().Awake();
        Step1Down.SetTrigger("Step1Down");
        FullDown.SetTrigger("FullDefDie");
        Invoke("typeStep1", 2.8f);
    }
    private void typeStep1()
    {
        typestep1.SetActive(true);
        audioStep1.SetActive(true);
    }
    private void button()
    {
        shadowButton.SetActive(true);
        Button.SetActive(true);
    }
}
