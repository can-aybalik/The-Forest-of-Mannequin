using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightController : MonoBehaviour
{

    public GameObject flashlight;
    public AudioSource openFlash;
    public AudioSource closeFlash;
    public GameObject flashlightOnTable;
    

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.F) && !flashlightOnTable.activeSelf)
        {
            if (flashlight.activeSelf)
            {
                flashlight.SetActive(false);
                closeFlash.Play();
            }
            else
            {
                flashlight.SetActive(true);
                openFlash.Play();
            }
        }

    }
}
    