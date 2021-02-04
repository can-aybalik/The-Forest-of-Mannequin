using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerController : MonoBehaviour
{

    
    public AudioSource glitch;
    public CameraShake cameraShake;

    public NoteController noteController;
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
        if(other.tag == "Player" && ToyOnGirlsHouse.triggered && firstTime)
        {
            firstTime = false;
            noteController.triggered = true;
            noteController.shutdown = true;
            glitch.Play();
            StartCoroutine(cameraShake.Shake(.60f, 0f));
        }
    }


}
