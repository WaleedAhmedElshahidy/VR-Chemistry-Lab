using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitrationController : MonoBehaviour
{
    [SerializeField] GameObject silver;
    [SerializeField] GameObject start;
    [SerializeField] GameObject finish;
    [SerializeField] GameObject scorem;

    private bool on;
    private ScoreManagerHana score;
    // Start is called before the first frame update
    void Start()
    {
        //silver = GameObject.FindGameObjectWithTag("AgNO3").GetComponent<ParticleSystem>();
        silver.SetActive(false);
        on = false;
        start.SetActive(false);
        finish.SetActive(false);
        scorem = GameObject.FindWithTag("Score");
        score = scorem.GetComponent<ScoreManagerHana>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void OnMouseDown()
    {

        if (!on)
        {
            Debug.Log("Pressed primary button again.");
            silver.SetActive(true);
            start.SetActive(true);
            finish.SetActive(false);
            on = true;
            Debug.Log(on);
            if (score.points < 5)
            {
                score.points = 5;
            }
        }
        else
        {
            silver.SetActive(false);
            start.SetActive(false);
            finish.SetActive(true);
            on = false;
            Debug.Log(on);
        }
    }

    //void OnMouseOver()
    //{
    //    if (!on)
    //    {
    //        /start.SetActive(true);
    //        finish.SetActive(false);

    //    }
    //    else
    //    {
           
    //    }
    //}
}
