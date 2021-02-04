using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryDoor : MonoBehaviour
{

    public AudioSource locked;
    public AudioSource opened;
    public FactoryKey factoryKey;
    public bool inRange = false;

    public Animator doorAnim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(inRange && Input.GetMouseButtonDown(0))
        {
            if (factoryKey.gotKey)
            {
                opened.Play();
                doorAnim.SetBool("isOpened", true);
                doorAnim.SetBool("isClosed", false);
            }
            else
            {
                locked.Play();
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            inRange = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            inRange = false; ;
        }
    }
}
