using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetAshrakatStep1 : MonoBehaviour
{
    public Animator animator;
    public Animator animator2;
    public GameObject typestep;
    public AudioSource aud;
    public GameObject grabstep1;
    public GameObject Grababble;
    public Text text;
    public GameObject StartButton;
    public GameObject StartButtonShadow;
    public GameObject Timer;
    void Start()
    {
        Invoke("StartButtonActive",28.5f);
    }
    // Update is called once per frame
    void Update()
    {

    }
    public void Step1()
    {
        Timer.SetActive(true);
        animator.SetBool("AshrakatFullDefDown", true);
        animator2.SetBool("AshrakatGetStep1",true);
        grabstep1.GetComponent<OVRGrabbable>().enabled = true;
        Grababble.GetComponent<OVRGrabbable>().Awake();
        Invoke("type", 2.8f);
    }
    private void type()
    {
        typestep.SetActive(true);
        aud.Play();
    }
    private void StartButtonActive()
    {
        StartButton.SetActive(true);
        StartButtonShadow.SetActive(true);
    }
}
