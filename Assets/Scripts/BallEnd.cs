using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
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
        // if the ball enters the Ball End area
        if (other.gameObject.GetComponent<Ball>() != null)
        {
            var theBall = other.gameObject.GetComponent<Rigidbody>();
            theBall.transform.position = GameObject.FindGameObjectWithTag("Ball Start").transform.position;
            theBall.velocity = Vector3.zero;
            print("Ball has teleported and its speed is reset.");
            
        }
    }
}
