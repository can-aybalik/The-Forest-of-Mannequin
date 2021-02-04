using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteController : MonoBehaviour
{
    public GameObject text;

    public GameObject paperView;
    public GameObject paperView2;

    public AudioSource paperPick;
    public AudioSource paperPut;
    
    bool inRange = false;
    bool paperShowing = false;

    public bool triggered = false;

    public bool shutdown = false;

    public GameObject light;
    public GameObject flashlight;

    public AudioSource flashlightOff;
    public AudioSource horrorSound;

    public GameObject fButton;
    public GameObject redGuy;

    bool firstTime = true;



    // Update is called once per frame
    void Update()
    {


        if(inRange && Input.GetKeyDown(KeyCode.E) && !paperShowing)
        {
            if (!triggered)
            {
                Debug.Log("girdi");
                paperView.SetActive(true);
            }
            else
            {
                paperView2.SetActive(true);
            }
            
            paperPick.Play();
            paperShowing = true;
        }
        else if (inRange && Input.GetKeyDown(KeyCode.E) && paperShowing)
        {
            if (!triggered)
            {
                paperView.SetActive(false);
            }
            else
            {
                paperView2.SetActive(false);
                shutdown = true;
            }
            paperPut.Play();
            paperShowing = false;
        }

        if(fButton.active && Input.GetKeyDown(KeyCode.F))
        {
            fButton.SetActive(false);
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            text.SetActive(true);
            inRange = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            text.SetActive(false);
            inRange = false;
            paperView.SetActive(false);
            paperView2.SetActive(false);
            paperShowing = false;
            //paperPut.Play();

            if (shutdown && firstTime)
            {
                light.SetActive(false);
                flashlight.SetActive(false);
                flashlightOff.Play();
                horrorSound.Play();
                fButton.SetActive(true);
                redGuy.SetActive(true);
                firstTime = false;
            }
        }
    }
}
