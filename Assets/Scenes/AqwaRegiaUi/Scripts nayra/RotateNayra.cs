using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LiquidVolumeFX;

public class RotateNayra : MonoBehaviour
{
    private LiquidVolume fill;
    public GameObject particle;
    public GameObject collide;
    private float angle;
    // Start is called before the first frame update
    void Start()
    {
        fill = gameObject.GetComponent<LiquidVolume>();
        particle.SetActive(false);
        collide.SetActive(false);
    }

    void Update()
    {
        //angle = transform.rotation.eulerAngles.x;
        angle = transform.rotation.eulerAngles.x;

        if (angle >= 333f || angle <= 20)
        {
            Debug.Log("rotate>50");
            fill.level -= 0.004f;
            particle.SetActive(true);
            collide.SetActive(true);
            if (fill.level <= 0)
            {
                particle.SetActive(false);
                collide.SetActive(false);
            }


        }
        else
        {
            particle.SetActive(false);
            collide.SetActive(false);

        }

    }
}



