using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lastCut : MonoBehaviour
{

    public PlayerMovement playerMovement;
    public FactoryLittleRed factoryLittleRed;
    public GameObject running;
    public AudioSource walk;
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
        if(other.tag == "Player" && factoryLittleRed.triggered)
        {
            running.SetActive(true);
            playerMovement.canMove = false;
        }
    }
}
