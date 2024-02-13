using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnetController : MonoBehaviour
{
    //[SerializeField] GameObject magnet;
    [SerializeField] GameObject magnetLabel;
    [SerializeField] GameObject scorem;

    private ScoreManagerHana score;

    public bool collide;

    // Start is called before the first frame update
    void Start()
    {
        scorem = GameObject.FindWithTag("Score");
        score = scorem.GetComponent<ScoreManagerHana>();
    }
   

    // Update is called once per frame
    void Update()
    {
        OVRInput.Update();
        if (OVRInput.Get(OVRInput.Button.SecondaryHandTrigger))
        {
            magnetLabel.SetActive(false);
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Magnet"))
        {
            GetComponent<Rigidbody>().isKinematic = true;
            collide = true;
            magnetLabel.SetActive(false);
            if (score.points < 3)
            {
                score.points = 3;
            }
        }
    }
}
