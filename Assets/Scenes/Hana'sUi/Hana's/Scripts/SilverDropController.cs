using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LiquidVolumeFX;

public class SilverDropController : MonoBehaviour
{
    [SerializeField] Animator anim;
    [SerializeField] ParticleSystem ColorStain;

    private LiquidVolume foam;
    private bool success;

    // Start is called before the first frame update
    void Start()
    {
        foam = gameObject.GetComponent<LiquidVolume>();
        anim = gameObject.GetComponent<Animator>();
        ColorStain= GameObject.FindGameObjectWithTag("ColorStain").GetComponent<ParticleSystem>();
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
            Debug.Log("Silver");
            StartCoroutine(Begin());
        }
    }
    private IEnumerator Begin()
    {
        Debug.Log("Animation");
        yield return new WaitForSeconds(5f);
        anim.SetTrigger("Silver1");
        for (float i = 0.0087f; i < 0.1; i += 0.0001f)
        {

            foam.foamThickness += 0.0001f;
        }
        yield return new WaitForSeconds(5f);
        ColorStain.Play();
        yield return new WaitForSeconds(5f);
        ColorStain.Stop();
        anim.SetTrigger("RedFail");
        yield return new WaitForSeconds(10f);
        anim.SetTrigger("RedSuccess");
        success = true;
    }
}
