using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LiquidVolumeFX;

public class SpillPointController : MonoBehaviour
{
    private LiquidVolume spill;
    [SerializeField] GameObject spillpoint;
    [SerializeField] GameObject Liquid;
    // Start is called before the first frame update
    void Start()
    {
        spill = gameObject.GetComponent<LiquidVolume>();
        Liquid.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (spillpoint.activeInHierarchy)
        {
            spill.level -= 0.01f;
            Liquid.SetActive(true);
            Liquid.transform.position = new Vector3(gameObject.transform.position.x + 0.07f, gameObject.transform.position.y+ 0.0986f, gameObject.transform.position.z);
        }
        else
        {
            //spill.level += 0.01f;
        }
    }
}
