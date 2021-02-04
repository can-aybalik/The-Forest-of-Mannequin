using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public AudioSource woodSlow;
    public AudioSource woodFast;
    public AudioSource grassSlow;
    public AudioSource grassFast;
    public AudioSource groundSlow;
    public AudioSource groundFast;

    public bool canMove = true;

    float speed = 10f;
    public float gravity = -9.81f;
    bool inHouse = true;
    public static bool inGirlsHouse = false;

    Vector3 velocity;

    private void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (true)
        {
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                speed = 20f;
            }
            else if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                speed = 10f;
            }

            if (!canMove)
                speed = 0f;


            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");

            Vector3 move = transform.right * x + transform.forward * z;

            controller.Move(move * speed * Time.deltaTime);

            velocity.y += gravity * Time.deltaTime;

            controller.Move(velocity * Time.deltaTime);

            if (Mathf.Abs(move.z) > 0.4 || Mathf.Abs(move.x) > 0.2) //Moving Case
            {
                if (inHouse) //HOUSE
                {
                    grassSlow.Stop();
                    grassFast.Stop();
                    groundSlow.Stop();
                    groundFast.Stop();

                    if (!woodSlow.isPlaying && speed == 10f)
                    {
                        woodFast.Stop();
                        woodSlow.Play();
                    }
                    else if (!woodFast.isPlaying && speed == 20f)
                    {
                        woodSlow.Stop();
                        woodFast.Play();
                    }
                }

                else if (!inHouse && inGirlsHouse) //GIRL'S HOUSE
                {
                    grassSlow.Stop();
                    grassFast.Stop();
                    woodSlow.Stop();
                    woodFast.Stop();

                    if (!groundSlow.isPlaying && speed == 10f)
                    {
                        groundFast.Stop();
                        groundSlow.Play();
                    }
                    else if (!groundFast.isPlaying && speed == 20f)
                    {
                        groundSlow.Stop();
                        groundFast.Play();
                    }

                }
                else //OUTSIDE
                {
                    groundSlow.Stop();
                    groundFast.Stop();
                    woodSlow.Stop();
                    woodFast.Stop();

                    if (!grassSlow.isPlaying && speed == 10f)
                    {
                        grassFast.Stop();
                        grassSlow.Play();
                    }
                    else if (!grassFast.isPlaying && speed == 20f)
                    {
                        grassSlow.Stop();
                        grassFast.Play();
                    }


                }


            }
            else
            {
                //ALAYINI KAPAT
                woodSlow.Stop();
                woodFast.Stop();
                grassSlow.Stop();
                grassFast.Stop();
                groundSlow.Stop();
                groundFast.Stop();
            }
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "House")
        {
            inHouse = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "House")
        {
            inHouse = false;
        }

    }


}
