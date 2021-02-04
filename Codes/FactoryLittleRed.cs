using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FactoryLittleRed : MonoBehaviour
{
    public AudioSource sound;
    public GameObject factoryReds;
    public GameObject text;
    public GameObject redToy;
    bool inRange = false;
    public bool triggered = false;
    public GameObject doorLocked;
    public GameObject running;
    public Light light;
    public PlayerMovement playerMovement;

    public GameObject flashlight;

    public AudioSource girlIsHere;
    public AudioSource glitch;

    private IEnumerator coroutine;
    private IEnumerator coroutine2;
    private IEnumerator coroutine3;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(inRange && Input.GetKeyDown(KeyCode.E))
        {
            playerMovement.canMove = false;
            sound.Play();
            factoryReds.SetActive(true);
            doorLocked.SetActive(true);
            redToy.SetActive(false);
            triggered = true;
            text.SetActive(false);
            girlIsHere.PlayDelayed(1);

            coroutine = WaitAndPrint(3.0f);
            StartCoroutine(coroutine);

            coroutine2 = WaitAndPrint2(5.0f);
            StartCoroutine(coroutine2);

            coroutine3 = WaitAndPrint3(10.0f);
            StartCoroutine(coroutine3);
        }

    }

    private IEnumerator WaitAndPrint(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        light.color = Color.red;
        running.SetActive(true);
        glitch.Play();
    }

    private IEnumerator WaitAndPrint2(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        flashlight.SetActive(false);
    }

    private IEnumerator WaitAndPrint3(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        SceneManager.LoadScene(0);
   
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player" && !triggered)
        {
            inRange = true;
            text.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player" && !triggered)
        {
            inRange = false;
            text.SetActive(false);
        }

    }
}
