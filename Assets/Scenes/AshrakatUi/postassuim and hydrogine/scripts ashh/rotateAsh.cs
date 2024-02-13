using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using LiquidVolumeFX;
public class rotateAsh : MonoBehaviour
{
    private LiquidVolume fill;
    public GameObject particle;
    public GameObject collide;
    public GameObject beakerfill;
    public GameObject flasktest;
    public GameObject scorePoints;
    private float angleX;
    private float positionY;
    private float Zsize;
    private scoreAsh getPoints;
    bool bol;
    public Animator Step2Anim;
    public Animator Step1Down;
    public GameObject typestep2;
    public GameObject audstep2;
    public GameObject emptyflask; 
    private LiquidVolume emptyflasklevel;
    public GameObject grabstep1;
    public GameObject Grababble;
    public GameObject failedText;
    public GameObject failedVoice;
    public Animator failedDown;
    void Start()
    {
        Zsize = 0.0001f;
        fill = gameObject.GetComponent<LiquidVolume>();
        emptyflasklevel = emptyflask.GetComponent<LiquidVolume>();
        particle.SetActive(false);
        collide.SetActive(false);
        scorePoints = GameObject.FindWithTag("score");
        getPoints = scorePoints.GetComponent<scoreAsh>();
        
    }

    void Update()
    {
        angleX = transform.rotation.eulerAngles.x;


        if (angleX >= 320f || angleX <= 52)
        {
            fill.level -= 0.001f;
            bol=beakerfill.GetComponent<fillControllerAsh>().beakertest;
            if (bol == true  )
            {
               beakerfill.GetComponent<LiquidVolume>().level += 0.0015f ;
               beakerfill.GetComponent<BoxCollider> ().size += new Vector3(0, 0, Zsize);
               getPoints.points = 1;
               

            }
            
            particle.SetActive(true);
            collide.SetActive(true);

            if (fill.level <= 0.1f)
            {
                beakerfill.GetComponent<fillControllerAsh>().beakertest=false;
                particle.SetActive(false);
                collide.SetActive(false);
                if(beakerfill.GetComponent<fillControllerAsh>().filledbool==false)
                {
                    Step1Down.SetBool("AshrakatDownStep1",true);
                    failedDown.SetBool("failedDown",true);
                    Invoke("failedType",2.5f);
                }
                if (emptyflasklevel.level > 0.3f)
                {
                        Step1Down.SetBool("AshrakatDownStep1",true);
                        Step2Anim.SetBool("Step2Down",true);
                        Invoke("audio", 2.8f);
                    grabstep1.GetComponent<OVRGrabbable>().enabled = true;
                    Grababble.GetComponent<OVRGrabbable>().Awake();
                }
            }


        }
        else
        {
            particle.SetActive(false);
            collide.SetActive(false);

        }

    }
    private void audio()
    {
        audstep2.SetActive(true);
        typestep2.SetActive(true);
    }
    private void failedType()
    {
        failedText.SetActive(true);
        failedVoice.SetActive(true);
    }
    
}
