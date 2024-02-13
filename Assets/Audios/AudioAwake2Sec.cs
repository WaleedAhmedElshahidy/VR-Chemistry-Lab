using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioAwake2Sec : MonoBehaviour
{
    public AudioSource aud;
    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    private void Start()
    {
        Invoke("playAudio",2);
    }
    void playAudio()
    {
        aud.Play();
    }
}
