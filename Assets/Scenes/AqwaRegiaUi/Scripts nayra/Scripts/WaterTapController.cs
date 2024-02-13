using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterTapController : MonoBehaviour
{
    [SerializeField] ParticleSystem water;
    private bool WaterOn;
    // Start is called before the first frame update
    void Start()
    {
        water = GameObject.FindGameObjectWithTag("Water").GetComponent<ParticleSystem>();
        water.Stop();
        WaterOn = false;

    }
    void OnMouseDown()
    {
        Debug.Log("Click");
        // this object was clicked - do something
        if (!WaterOn)
        {
            water.Play();
            WaterOn = true;

        }
        else
        {
            water.Stop();
            WaterOn = false;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
