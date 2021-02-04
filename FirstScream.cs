using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScream : MonoBehaviour
{
    bool firstTime = true;
    public AudioSource firstScream;
    public AudioSource hauntedForest;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (GirlsDoor.doorOpened)
            hauntedForest.Stop();
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (firstScream && firstTime)
        {
            firstScream.Play();
            hauntedForest.Play();
            firstTime = false;
        }
        
    }
}
