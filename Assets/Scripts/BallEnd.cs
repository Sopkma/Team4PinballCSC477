using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallEnd : MonoBehaviour
{
    private GameObject tubeDoor;
    private AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        tubeDoor = GameObject.FindGameObjectWithTag("Tube Door");
        audioSrc = GetComponent<AudioSource>();
    }


    private void OnTriggerEnter(Collider other)
    {
        // if the ball enters the Ball End area
        if (other.gameObject.GetComponent<Ball>() != null)
        {
            var theBall = other.gameObject.GetComponent<Rigidbody>();
            theBall.transform.position = GameObject.FindGameObjectWithTag("Ball Start").transform.position;
            theBall.velocity = Vector3.zero;
            audioSrc.Play();
            print("Ball has teleported and its speed is reset.");

            if (tubeDoor != null)
            {
                tubeDoor.SetActive(false);
            }
            else
            {
                tubeDoor = GameObject.FindGameObjectWithTag("Tube Door");
                tubeDoor.SetActive(false);
            }
            
            
        }
    }
}
