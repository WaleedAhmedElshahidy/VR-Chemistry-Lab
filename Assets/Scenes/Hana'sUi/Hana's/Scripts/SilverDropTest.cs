using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LiquidVolumeFX;

public class SilverDropTest : MonoBehaviour
{
    [SerializeField] Animator anim;
    [SerializeField] ParticleSystem ColorStain;
    [SerializeField] GameObject scorem;
    //[SerializeField] GameObject drop;

    private LiquidVolume foam;
    private bool triggered;
    private bool success;
    private ScoreManagerHana score;
    private DropController change;
    public GameObject DisableAllObject;
    public Animator SuccessDown;
    public Animator HanaStep5Die;
    public GameObject secesstypeActivate;
    public GameObject secessVoiceActivate;
    // Start is called before the first frame update
    void Start()
    {
        foam = gameObject.GetComponent<LiquidVolume>();
        anim = gameObject.GetComponent<Animator>();
        ColorStain = GameObject.FindGameObjectWithTag("ColorStain").GetComponent<ParticleSystem>();
        scorem = GameObject.FindWithTag("Score");
        score = scorem.GetComponent<ScoreManagerHana>();
        change = gameObject.GetComponent<DropController>();
        success = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("AgNO3"))
        {
            if (change.changed)
            {
                Debug.Log("Silver");
                triggered = true;
                Invoke("Silver", 5.0f);
            }
            
        }
        else
        {
            triggered = false;
        }
    }

    private void Silver()
    {
        anim.SetTrigger("Silver1");
        if (score.points < 6)
        {
            score.points = 6;
        }
        
        for (float i = 0.0087f; i < 0.1; i += 0.0001f)
        {

            foam.foamThickness += 0.0001f;
        }
        if (triggered)
        {
            Invoke("colorStain", 5.0f);
        }
    }

    private void colorStain()
    {
        ColorStain.Play();
        if (score.points < 7)
        {
            score.points = 7;
        }
        if (triggered)
        {
            Invoke("redFail", 5.0f);
        }
    }

    private void redFail()
    {
        ColorStain.Stop();
        anim.SetTrigger("RedFail");
        if (score.points < 8)
        {
            score.points = 8;
        }
        if (triggered)
        {
            Invoke("redSuccess", 5.0f);
        }
    }

    private void redSuccess()
    {
        anim.SetTrigger("RedSuccess");
        SuccessDown.SetBool("seccessDown",true);
        HanaStep5Die.SetBool("HanaStep5Die",true);
        Invoke("typeSucess",2.4f);
        DisableAllObject.SetActive(true);
        if (score.points < 9)
        {
            score.points = 9;
        }
    }
    private void typeSucess()
    {
        secesstypeActivate.SetActive(true);
        secessVoiceActivate.SetActive(true);
    }
}
