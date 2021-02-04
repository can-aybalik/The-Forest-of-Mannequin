using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toy : MonoBehaviour
{
    public GameObject text;
    bool inRange = false;
    public GameObject speechText;
    public AudioSource jumpscare;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(inRange && Input.GetKeyDown(KeyCode.E))
        {
            speechText.SetActive(true);
            text.SetActive(false);
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        text.SetActive(true);
        inRange = true;
    }

    private void OnTriggerExit(Collider other)
    {
        text.SetActive(false);
        inRange = false;
        speechText.SetActive(false);
    }
}
