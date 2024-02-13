using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LiquidVolumeFX;

public class foameffect : MonoBehaviour
{
   
    private BoxCollider box;
    public GameObject foamParticle;
    
    // Start is called before the first frame update
    void Start()
    {
        box = gameObject.GetComponent<BoxCollider>();
        foamParticle.SetActive(false);


        //foam = gameObject.GetComponent<LiquidVolume>();
       
    }

    // Update is called once per frame
     void Update()
    {

    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Potassuim"))
        {
            foamParticle.SetActive(true);
            


        }
    }
}
