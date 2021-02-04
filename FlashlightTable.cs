using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightTable : MonoBehaviour
{

    public GameObject text;
    public GameObject flashlight;
    bool inRange = false;
    public AudioSource pickUpSound;
    public GameObject flashlightOnCamera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (inRange && Input.GetKeyDown(KeyCode.E) && flashlight.activeSelf)
        {
            flashlight.SetActive(false);
            text.SetActive(false);
            flashlightOnCamera.SetActive(true);
            pickUpSound.Play();

        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player" && flashlight.activeSelf)
        {
            text.SetActive(true);
            inRange = true; 
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player" && flashlight.activeSelf)
        {
            text.SetActive(false);
            inRange = false;
        }
    }
}
