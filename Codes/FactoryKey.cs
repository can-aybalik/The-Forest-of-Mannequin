using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryKey : MonoBehaviour
{
    public GameObject key;
    public GameObject text;
    public AudioSource picked;
    public HordeTrigger hordeTrigger;
    public bool gotKey = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }   

    // Update is called once per frame
    void Update()
    {
        if(text.active && Input.GetKeyDown(KeyCode.E))
        {
            picked.Play();
            gotKey = true;
            hordeTrigger.triggered = true;
            key.SetActive(false);
            //text.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            text.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            text.SetActive(false);
        }
    }
}

