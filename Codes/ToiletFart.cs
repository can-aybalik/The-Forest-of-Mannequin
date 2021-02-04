using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToiletFart : MonoBehaviour
{

    public AudioSource fart;
    public GameObject text;
    public GameObject fartText;
    bool inRange;
    bool firstTime = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(inRange && Input.GetKeyDown(KeyCode.E) && firstTime)
        {
            fart.Play();
            fartText.SetActive(true);
            firstTime = false;
            text.SetActive(false);
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (firstTime)
        {
            inRange = true;
            text.SetActive(true);
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        inRange = false;
        text.SetActive(false);
        fartText.SetActive(false);
    }
}
