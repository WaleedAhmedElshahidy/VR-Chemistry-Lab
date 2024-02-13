using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LiquidVolumeFX;

public class FillControlNayra : MonoBehaviour
{
    private LiquidVolume fill;
    private LiquidVolume col;
    private BoxCollider box;
    public GameObject particle;
    public GameObject particle2;
    private float Ysize;
    private int count = 0;

    bool flag1;
    public Animator Step1Die;
    public Animator Step2Down;
    public GameObject Step2Text;
    public GameObject Step2Voice;
    public Animator secessanim;
    public Animator resultDie;
    public GameObject failedText;
    public GameObject failedVoice;
    public Animator failedDown;
    public GameObject secessVoice;
    public GameObject secessText;
    public Animator secessDie;
    public Animator step2Die;
    // Start is called before the first frame update
    void Start()
    {
        fill = gameObject.GetComponent<LiquidVolume>();
        box = gameObject.GetComponent<BoxCollider>();
        col = gameObject.GetComponent<LiquidVolume>();
        particle.SetActive(false);
        Ysize = 0.00025f;
        //count = 0;
        flag1 = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerStay(Collider other)
    {

        if (other.gameObject.CompareTag("Liquid"))
        {
            
            //ScoreManager.instance.AddPoint();
            if (PointScoreNayra.score == 0)
            {
                PointScoreNayra.score += 1;
                PointScoreNayra.instance.AddPoint();
                //count = count + 1;
                //count = 1;

            }
            Debug.Log(PointScoreNayra.score);

            Debug.Log("Liquid");
            if (flag1 == false)
            {
                fill.level += 0.0009f;
                box.size += new Vector3(0, 0, Ysize);
                

            }
            else
            {
                particle2.SetActive(true);
                particle.SetActive(true);
                failedDown.SetBool("failedDown",true);
                step2Die.SetBool("Step2Die",true);
                resultDie.SetBool("ResultDie",true);
                secessDie.SetBool("secessDie",true);
                Invoke("failedType",2.5f);
            }

            if (fill.level >= 0.42 && fill.level < 0.45)
            {
                if (PointScoreNayra.score == 1)
                {
                    PointScoreNayra.score += 1;
                    //NayraPoints.scoreText.text = NayraPoints.score.ToString() + "  POINTS ";
                    PointScoreNayra.instance.AddPoint();
                    //count = count + 1;
                    //count = 1;

                }
                Debug.Log(PointScoreNayra.score);
                //step2
                Step1Die.SetBool("Step1Die",true);
                Step2Down.SetBool("Step2Down",true);
                Invoke("TypeStep2",2.5f);
            }

        }

        if (other.gameObject.CompareTag("colorr"))
        {
            if (PointScoreNayra.score == 2)
            {
                PointScoreNayra.score += 1;
                //NayraPoints.scoreText.text = NayraPoints.score.ToString() + "  POINTS ";
                PointScoreNayra.instance.AddPoint();
                //count = count + 1;
                //count = 1;

            }
            Debug.Log(PointScoreNayra.score);

            Debug.Log("colorr");
            flag1 = true;
            fill.level += 0.0009f;
            box.size += new Vector3(0, 0, Ysize);
            //ScoreManager.instance.AddPoint();
            if (fill.level >= 0.60 && fill.level < 0.63)
            {
                Invoke("seccess",30.2f);
                if (PointScoreNayra.score == 3)
                {
                    PointScoreNayra.score += 1;
                    //NayraPoints.scoreText.text = NayraPoints.score.ToString() + "  POINTS ";
                    PointScoreNayra.instance.AddPoint();
                    //count = count + 1;
                    //count = 1;

                }
                Debug.Log(PointScoreNayra.score);
            }
            if (fill.level >= 0.68)
            {
                Debug.Log("Experiment Failed");
                particle2.SetActive(true);
                particle.SetActive(true);
                //faail
                failedDown.SetBool("failedDown",true);
                resultDie.SetBool("ResultDie",true);
                secessDie.SetBool("secessDie",true);
                Invoke("failedType",2.5f);
                //resultdie
            }

        }



        if (other.gameObject.CompareTag("Water"))
        {
            Debug.Log("Water");

            fill.level += 0.001f;
            box.size += new Vector3(0, Ysize, 0);
        }
    }
    public void TypeStep2()
    {
        Step2Text.SetActive(true);
        Step2Voice.SetActive(true);
    }
    private void seccess()
    {
        secessanim.SetBool("secessDown",true);
        Invoke("secessType",2.5f);
        resultDie.SetBool("ResultDie",true);
    }
    private void failedType()
    {
        failedText.SetActive(true);
        failedVoice.SetActive(true);
    }
    private void secessType()
    {
        secessText.SetActive(true);
        secessVoice.SetActive(true);
    }
}
