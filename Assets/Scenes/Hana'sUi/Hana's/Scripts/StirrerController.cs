using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StirrerController : MonoBehaviour
{
    [SerializeField] GameObject magnet;
    [SerializeField] GameObject Label;
    [SerializeField] GameObject start;
    [SerializeField] GameObject scorem;

    private int rotationAngle = 20;
    private int speed = 8;
    private bool on;
    private ScoreManagerHana score;
    private MagnetController detect;
    public Animator HanaStep3DownAnim;
    public Animator HanaStep2DieAnim;
    public GameObject grabmagnet;
    public GameObject Grababblemagnet;
    public GameObject Step3Type;
    public GameObject Step3Voice;
    public Animator Step3Die;
    public Animator Step4Down;
    //public GameObject Part1;
    //public GameObject Part2;
    public GameObject Step4Text;
    public GameObject Step4Voice;
    public GameObject OVRTitrationEnable;
    // Start is called before the first frame update
    void Start()
    {
        on = false;
        scorem = GameObject.FindWithTag("Score");
        score = scorem.GetComponent<ScoreManagerHana>();
        detect = magnet.GetComponent<MagnetController>();
        //Part1.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (OVRInput.Get(OVRInput.Button.Two))
        {
            //Part2.SetActive(true);
            Label.SetActive(false);
            start.SetActive(true);
            Step3Die.SetBool("HanaStep3Die",true);
            Step4Down.SetBool("HanaStep4Down",true);
            Invoke("typeStep4",2.8f);
            on = true;
            if (score.points < 4)
            {
                score.points = 4;
            }
            


        }
    }

    void OnMouseDown()
    {
        Label.SetActive(false);
        start.SetActive(true);
        on = true;
        score.points = 3;
    }
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag=="K2CrO4")
        {
            HanaStep3DownAnim.SetBool("HanaStep3Down",true);
            HanaStep2DieAnim.SetBool("HanaStep2Die",true);
            Invoke("type",2.8f);
            grabmagnet.GetComponent<OVRGrabbable>().enabled = true;
            Grababblemagnet.GetComponent<OVRGrabbable>().Awake();

            if (on && detect.collide)
            {
                var value = Time.deltaTime * rotationAngle * speed;
                magnet.transform.Rotate(0, 0, value);
            }
            

        }
    }
    void type()
    {
        Step3Type.SetActive(true);
        Step3Voice.SetActive(true);
    }
    void typeStep4()
    {
        Step4Text.SetActive(true);
        Step4Voice.SetActive(true);
        OVRTitrationEnable.GetComponent<TitrationOVR>().enabled = true;
    }
}
