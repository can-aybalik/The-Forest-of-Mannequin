using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirlsHouseCollision : MonoBehaviour
{
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
        if(other.tag == "Player")
        {
            PlayerMovement.inGirlsHouse = true;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            PlayerMovement.inGirlsHouse = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            PlayerMovement.inGirlsHouse = false;
        }
    }

    
}
