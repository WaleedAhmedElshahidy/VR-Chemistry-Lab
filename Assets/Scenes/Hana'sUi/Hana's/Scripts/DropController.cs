using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DropController : MonoBehaviour
{
    [SerializeField] Animator anim;
    [SerializeField] GameObject scorem;

    private GameObject dropper;
    private PippetteControllerHana drop;
    private bool silver;
    private ScoreManagerHana score;

    public bool changed;
    public Animator GetStep2Hana;
    public Animator HanaStep1Die;
    public GameObject Step2Text;
    public GameObject Step2Voice;
    public GameObject grabstep2;
    public GameObject Grababble2;
    public GameObject Stirrer;
    public GameObject magnitcont;
    public GameObject triggercanvas;

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        dropper= GameObject.FindWithTag("Dropper");
        drop = dropper.GetComponent<PippetteControllerHana>();
        scorem = GameObject.FindWithTag("Score");
        score = scorem.GetComponent<ScoreManagerHana>();
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Drop"))
        {
            anim.SetTrigger("K2CrO4");
            triggercanvas.SetActive(false);
            Invoke("Step2",2.8f);
            changed = true;
            score.points = 2;

           
        }
        


    }
    void Step2()
    {
        GetStep2Hana.SetBool("GetHanaStep2",true);
        HanaStep1Die.SetBool("HanaStep1Die",true);
        Invoke("type",2);
        grabstep2.GetComponent<OVRGrabbable>().enabled = true;
        Grababble2.GetComponent<OVRGrabbable>().Awake();
        //make stirrercontroller active
        Stirrer.GetComponent<StirrerController>().enabled = true;
        magnitcont.GetComponent<MagnetController>().enabled = true;
    }
    void type()
    {
        Step2Text.SetActive(true);
        Step2Voice.SetActive(true);
    }
}
