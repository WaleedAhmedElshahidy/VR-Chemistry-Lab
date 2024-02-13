using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitrationOVR : MonoBehaviour
{
    [SerializeField] GameObject silver;
    [SerializeField] GameObject start;
    [SerializeField] GameObject finish;
    [SerializeField] GameObject dropper;
    private DropperOVR drop;

    private bool on;
    public GameObject typeStep5Active;
    public GameObject VoiceStep5Active;
    public Animator Step5Down;
    public Animator Step4Die;
    // Start is called before the first frame update
    void Start()
    {
        on = false;
        dropper = GameObject.FindWithTag("Dropper");
        drop = dropper.GetComponent<DropperOVR>();
    }

    // Update is called once per frame
    void Update()
    {
        OVRInput.Update();
        if (!drop.grabbed && OVRInput.Get(OVRInput.Button.One))
        {
            if (!on)
            {
                Debug.Log("Pressed primary button again.");
                silver.SetActive(true);
                start.SetActive(false);
                finish.SetActive(true);
                Step4Die.SetBool("HanaStep4Die",true);
                Step5Down.SetBool("Step5Down",true);
                Invoke("typeStep5",2);
                on = true;
            }
            else
            {
                silver.SetActive(false);
                start.SetActive(true);
                finish.SetActive(false);
                on = false;
            }
        }
    }
    private void typeStep5()
    {
        typeStep5Active.SetActive(true);
        VoiceStep5Active.SetActive(true);
    }
}
