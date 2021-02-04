using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToyOnGirlsHouse : MonoBehaviour
{

    public GameObject text;
    public AudioSource jumpscare;
    bool inRange = false;
    bool firstTime = true;

    public GameObject oldMan;
    public GameObject newMan;

    //public GameObject oldLight;
    //public GameObject newLight;

    public GameObject oldWardrobeDoor;
    public GameObject newWardrobeDoor;

    public GameObject oldChair;
    public GameObject newChair;

    public GameObject oldTypewriter;
    public GameObject newTypewriter;

    public GameObject oldNote;
    public GameObject newNote;

    public GameObject toyOnWardrobe;

    public static bool triggered = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(inRange && Input.GetKeyDown(KeyCode.E) && firstTime)
        {
            jumpscare.Play();
            firstTime = false;

            oldMan.SetActive(false);
            newMan.SetActive(true);

            //oldLight.SetActive(false);
            //newLight.SetActive(true);

            oldTypewriter.SetActive(false);
            newTypewriter.SetActive(true);

            oldNote.SetActive(false);
            newNote.SetActive(true);

            oldChair.SetActive(false);
            newChair.SetActive(true);

            oldWardrobeDoor.SetActive(false);
            newWardrobeDoor.SetActive(true);
            toyOnWardrobe.SetActive(false);



            text.SetActive(false);
            triggered = true;
            
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        text.SetActive(true);
        inRange = true;
    }

    private void OnTriggerExit(Collider other)
    {
        text.SetActive(false);
        inRange = false;
    }


}
