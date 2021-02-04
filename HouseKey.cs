using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseKey : MonoBehaviour
{

    public GameObject text;
    public GameObject key;
    public AudioSource pickUp;
    bool inRange = false;
    bool pickedUp = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(inRange && Input.GetKeyDown(KeyCode.E))
        {
            pickUp.Play();
            pickedUp = true;
            GirlsDoor.hasKey = true;
        }

        if (pickedUp)
        {
            key.SetActive(false);
            text.SetActive(false);
        }
            
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player" && !pickedUp)
        {
            text.SetActive(true);
            inRange = true;
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        text.SetActive(false);
        inRange = false;
    }
}
