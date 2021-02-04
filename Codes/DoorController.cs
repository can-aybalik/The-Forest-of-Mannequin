using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{

    
    public Animator doorAnim;
    bool closedDoor = true;
    public AudioSource doorOpen;
    public AudioSource doorClose;
    bool firstTime = true;

    // Update is called once per frame
    void Update()
    {
        if (DoorCollisionController.inRange)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (closedDoor)
                {
                    Debug.Log("Girdi");
                    doorAnim.SetBool("isOpened", true);
                    doorAnim.SetBool("isClosed", false);
                    closedDoor = false;
                    doorOpen.Play();
                    doorClose.Stop();
                }
                else
                {
                    doorAnim.SetBool("isOpened", false);
                    doorAnim.SetBool("isClosed", true);
                    closedDoor = true;
                    doorOpen.Stop();
                    doorClose.Play();
                }
                
            }
        }
        
    }
}
