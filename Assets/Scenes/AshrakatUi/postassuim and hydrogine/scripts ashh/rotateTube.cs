using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LiquidVolumeFX;

public class rotateTube : MonoBehaviour
{
    private LiquidVolume fill;
    //public GameObject foamparticle;
    public GameObject collide;
    private float angle;
    public GameObject tubetext;
    public GameObject scorePoints;
    private scoreAsh getPoints; 
    public GameObject pottasium;
    void Start()
    {
        pottasium.SetActive(false);
        tubetext.SetActive(true);
        fill = gameObject.GetComponent<LiquidVolume>();
        collide.SetActive(false);
        scorePoints = GameObject.FindWithTag("score");
        getPoints= scorePoints.GetComponent<scoreAsh>();
    }

    void Update()
    {
        angle = transform.rotation.eulerAngles.x;
        if (angle >= 320f || angle <= 24f)
        {
            pottasium.SetActive(true);
            tubetext.SetActive(false);
            fill.level -= 0.001f;
            
            getPoints.points=2; 
            getPoints.points=3; 
            collide.SetActive(true);
            
           //foamparticle.SetActive (true);


            if (fill.level <= 0)
            {
                Debug.Log("fill 0");
                pottasium.SetActive(false);
                collide.SetActive(false);
            }
        }
        
    }
}

