using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gobackhouse : MonoBehaviour
{

    public GameObject text;
    bool firstTime = true;


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
        if(other.tag == "Player" && firstTime && ToyOnGirlsHouse.triggered)
        {
            text.SetActive(true);
            firstTime = false;
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
