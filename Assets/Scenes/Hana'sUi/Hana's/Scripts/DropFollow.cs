using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropFollow : MonoBehaviour
{
    public ParticleSystem particle;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = new Vector3(particle.transform.position.x, particle.transform.position.y, particle.transform.position.z);
    }
}
