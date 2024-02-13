using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LiquidVolumeFX;


public class PippetteControllerHana : MonoBehaviour
{

    private LiquidVolume fill;
    private BoxCollider box;
    private float Ysize;
    private ScoreManagerHana score;
    private bool done;

    [SerializeField] ParticleSystem drop;
    [SerializeField] GameObject dropcollider;
    [SerializeField] GameObject scorem;


    public int count;
    public GameObject DropperLabel;
    // Start is called before the first frame update
    void Start()
    {

        fill = gameObject.GetComponent<LiquidVolume>();
        box = gameObject.GetComponent<BoxCollider>();
        scorem = GameObject.FindWithTag("Score");
        score = scorem.GetComponent<ScoreManagerHana>();
        count = 0;
        done = false;
        //drop = GameObject.FindGameObjectWithTag("Drop").GetComponent<ParticleSystem>();
        //Ysize = 0.00025f;
    }

    // Update is called once per frame
    void Update()
    {
        
        

    }
    void OnMouseDown()
    {
        if (fill.level != 0)
        {
            Debug.Log("Pressed primary button.");
            drop.Play();
            Invoke("DropCollider", 2.0f);
            count++;

        }
        else
        {
            dropcollider.SetActive(false);
        }
    }
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("K2CrO4"))
        {
            Debug.Log("In");
            done = true;
            fill.level += 0.001f;
            score.points = 1;
            Invoke("droppercanvas",2f);

            // box.size += new Vector3(0, Ysize, 0);


        }
    }

   private void DropCollider()
    {
        dropcollider.SetActive(true);

        
    }
    private void droppercanvas()
    {
        DropperLabel.SetActive(true);
    }
}
