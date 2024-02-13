using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LiquidVolumeFX;

public class DropperOVR : MonoBehaviour
{
    private LiquidVolume fill;
    private OVRGrabbable grab;

    [SerializeField] ParticleSystem drop;
    [SerializeField] GameObject dropcollider;

    public bool grabbed;
    // Start is called before the first frame update
    void Start()
    {
        fill = gameObject.GetComponent<LiquidVolume>();
        grab = gameObject.GetComponent<OVRGrabbable>();
    }

    // Update is called once per frame
    void Update()
    {
        grabbed = grab.isGrabbed;
        if (grabbed && OVRInput.Get(OVRInput.Button.One))
        {
            if (fill.level != 0)
            {
                Debug.Log("Pressed primary button.");
                drop.Play();
                Invoke("DropCollider", 2.0f);
            }
            else
            {
                dropcollider.SetActive(false);
            }
        }
    }

    private void DropCollider()
    {
        dropcollider.SetActive(true);

    }
}
