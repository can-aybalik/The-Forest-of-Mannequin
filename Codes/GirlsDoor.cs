using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirlsDoor : MonoBehaviour
{

    bool inRange = false;
    public AudioSource locked;
    public AudioSource opened;
    public static bool hasKey = false;
    public static bool doorOpened = false;
    bool notOpened = true;

    //Animators
    public Animator firstDoor;
    public Animator secondDoor;
    
    // Update is called once per frame
    void Update()
    {
        if(inRange && Input.GetMouseButtonDown(0))
        {
            if (hasKey)
            {   //SUCCESS
                if (notOpened)
                {
                    opened.Play();
                    firstDoor.SetBool("unlockDoor", true);
                    secondDoor.SetBool("unlockDoor", true);
                    notOpened = false;
                    doorOpened = true;
                }
            }
            else
            {
                locked.Play();
            }
        }
        
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            inRange = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
            inRange = false;
    }


}
