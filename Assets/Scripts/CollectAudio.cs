using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectAudio : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip audioClip;
    public AudioSource audioSource;
    
    void Start()
    {
        audioSource.clip = audioClip;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Diamond")
        {
            audioSource.Play();
        }
    }
}
