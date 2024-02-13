using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LiquidVolumeFX;
using UnityEngine.UI;


public class fillControllerAsh : MonoBehaviour
{
    private LiquidVolume fill;
    private BoxCollider box;
    public GameObject foamParticle;
    public ParticleSystem foamStop;
    public bool beakertest; 
    public Animator Result;
    public Animator step2;
    public GameObject typeresult;
    public GameObject audresult;
    public Animator PotassuimTrigger;
    private LiquidVolume empty;
    public GameObject sucessTypeActive;
    public GameObject sucessVoiceActive;
    public Animator seccessDown;
    public Animator ResultAashDie;
    public bool filledbool;
    public GameObject failTypeActive;
    public GameObject failVoiceActive;
    public Animator failDown;
    //public Text text;
    static public float time;
    private bool beakerfilled=false;
    void Start()
    {
        filledbool = false;
        beakertest = false;
        foamParticle.SetActive(false);
        empty = gameObject.GetComponent<LiquidVolume>();
    }
    void Update()
    {
        if(foamParticle.activeInHierarchy)
        {
            empty.level -= 0.01f;
        }

    }
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Water") || other.gameObject.CompareTag("Liquid"))
        {
            filledbool = true;
            beakertest= true;
            //inside = true;
            Debug.Log("triggered");
            beakerfilled=true;
        }
        if(other.gameObject.CompareTag("Potassuim"))
        {
            if(beakerfilled==true)
            {
                Invoke("PotassiumTest",5.0f);
                Invoke("ResultStep",4.8f);
            }else
            {
                failDown.SetBool("failedDown",true);
                Invoke("failType",2.5f);
            }
            
        }
    }
    void OnTriggerExit(Collider other)
    {

       if(other.gameObject.CompareTag("Water") || other.gameObject.CompareTag("Liquid")) 
        {
            //inside = false;
            beakertest= false;
            Debug.Log("triggered exit");

        }
    }

    void PotassiumTest(){
        PotassuimTrigger.SetTrigger("potassuimAnim");
        Invoke("particule",3);
        Invoke("foamDie",8.2f);
    }
    void foamDie()
    {
        foamStop.Stop();
    }
    void ResultStep(){
        step2.SetBool("Step2Away",true);
        Result.SetBool("ResultDown",true);
        Invoke("audio", 2.8f);
        
    } 
    private void audio()
    {
        audresult.SetActive(true);
        typeresult.SetActive(true);
    }
    private void particule()
    {
        foamParticle.SetActive(true);
        Invoke("secess",10);
    }
    private void secess()
    {
        AshrakatTimer.finish = true;
        ResultAashDie.SetBool("ResultDie",true);
        seccessDown.SetBool("seccessDown",true);
        Invoke("typesecuess",2.8f);
    }
    private void typesecuess()
    {
        sucessTypeActive.SetActive(true);
        sucessVoiceActive.SetActive(true);
        time = AshrakatTimer.timeRemaining;
        //text.text = time.ToString();
    }
    private void failType()
    {
        failTypeActive.SetActive(true);
        failVoiceActive.SetActive(true);
    }
}
