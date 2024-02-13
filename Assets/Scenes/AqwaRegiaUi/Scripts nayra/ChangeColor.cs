using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LiquidVolumeFX;

public class ChangeColor: MonoBehaviour
{
    private LiquidVolume fill;
    private LiquidVolume col;
    private BoxCollider box;
    private float Ysize;
    private Vector3 scaleChange;
    //private Vector3 scale;
    bool flag;
    [SerializeField] GameObject sphere;
    [SerializeField] Animator animator;
    public Animator Step2Die;
    public Animator ResultDown;
    public GameObject ResultText;
    public GameObject ResultVoice;
    //public string RED { get; private set; }

    //[SerializeField] Animator animatorY;

    // Start is called before the first frame update
    void Start()
    {
         flag = false;
        fill = gameObject.GetComponent<LiquidVolume>();
        box = gameObject.GetComponent<BoxCollider>();
        col = gameObject.GetComponent<LiquidVolume>();
        Ysize = 0.00025f;
        //scaleChange = new Vector3(0.01f, 0.01f, 0.01f);
        //scale = new Vector3(0.01f, 0.01f, 0.01f);

    }

    // Update is called once per frame
    void Update()
    {
        if(flag == true)
        if (sphere.transform.localScale.y > 0f && sphere.transform.localScale.x > 0f && sphere.transform.localScale.z > 0f )
        {
           
            sphere.transform.localScale -= new Vector3(0.0005f, 0.0005f, 0.0005f)*Time.deltaTime*20;
              
        }
        else
        {
                animator.enabled = true;
                // StartCoroutine(delay());
                //sphere.SetActive(false);
                //Invoke("7mada",5.1f);
        }

    }
    void OnTriggerEnter(Collider other)
    {
      
        if (other.gameObject.tag==("KMNO4")) //|| other.gameObject.CompareTag("Liquid"))
        {
            Debug.Log("KMNO4");
            flag = true;
            //sphere.transform.localScale += scaleChange;
            //fill.level += 0.001f;
            //box.size += new Vector3(0, Ysize, 0);
            if (sphere.transform.localScale.y > 0f && sphere.transform.localScale.x > 0f && sphere.transform.localScale.z > 0f)
            {
                Debug.Log("zerooo");
              

            }
        }
        if (other.gameObject.tag == ("colorr"))
        {
            
            
               Debug.Log("colorr");
               animator.SetTrigger("RED");
               //result
               if (fill.level >= 0.60 && fill.level < 0.63)
               {
                    ResultDown.SetBool("ResultDown",true);
                    Step2Die.SetBool("Step2Die",true);
                    Invoke("ResultType",2.5f);
               }
               
            
        }


        if (other.gameObject.tag == ("Liquid"))
        {
            Debug.Log("Liquid");
            //animator.enabled = true;
            animator.SetTrigger("HCL");
        }


    }



    void OnCollisionStay(Collision other)
    {
    }
    private void ResultType()
    {
        ResultText.SetActive(true);
        ResultVoice.SetActive(true);
    }

/* IEnumerator delay()
    {
        yield return new WaitForSeconds(1);
          sphere.SetActive(false);
          col.liquidColor1 = new Color(0.9f, 0.9f, 0.98f, 1f);
          yield return new WaitForSeconds(1);
          //col.liquidColor1 = new Color(0.79f, 0.76f, 0.8f, 1f);
          //yield return new WaitForSeconds(2);
          col.liquidColor1 = new Color(0.81f, 0.62f, 1f, 1f);
          yield return new WaitForSeconds(1);
          col.liquidColor1 = new Color(0.5f, 0f, 1f, 1f);


          flag = false;
          StopCoroutine(delay());

          //col.liquidColor1 = new Color(0.5f, 0, 1, 1f);

         
    }*/
}
