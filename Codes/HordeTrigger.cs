using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HordeTrigger : MonoBehaviour
{

    public AudioSource glitch;
    public bool triggered = false;

    public GameObject horde;
    public CameraShake cameraShake;
    public bool firstTime = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player" && triggered && firstTime)
        {
            glitch.Play();
            firstTime = false;
            StartCoroutine(cameraShake.Shake(.60f, .0f));
        }
    }
}
