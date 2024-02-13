using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetHanaStep1 : MonoBehaviour
{
    public Animator animator;
    public Animator animator2;
    public GameObject typestep;
    public AudioSource aud;
    public GameObject grabstep1;
    public GameObject Grababble;
    public GameObject DropperOVRActivate;
    public GameObject startExpdisActive;
    public GameObject expButtonActive;
    public GameObject expButtonShadow;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("startExpActive",50.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Step1()
    {
        animator.SetBool("HanaFullDefDown", true);
        animator2.SetBool("HanaStep1Down",true);
        grabstep1.GetComponent<OVRGrabbable>().enabled = true;
        Grababble.GetComponent<OVRGrabbable>().Awake();
        DropperOVRActivate.GetComponent<DropperOVR>().enabled = true;
        Invoke("type", 2.8f);
    }
    private void type()
    {
        startExpdisActive.SetActive(false);
        typestep.SetActive(true);
        aud.Play();
    }
    private void startExpActive()
    {
        expButtonActive.SetActive(true);
        expButtonShadow.SetActive(true);
    }
}
