using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class point3insert : MonoBehaviour
{
    public int points;
    public GameObject ashs;
    private FinalAiModel finalscore;
    // Start is called before the first frame update
    void Start()
    {
        points = 3;
        finalscore = ashs.GetComponent<FinalAiModel>();
        finalscore.insertAiFunction();
        //when fail exp call this
    }

    // Update is called once per frame
    void Update()
    {

    }
}