using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBump : MonoBehaviour
{
    private Rigidbody theBall;
    private float launchForce = 30;
    // Start is called before the first frame update
    void Start()
    {
        theBall = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        var bumper = collision.gameObject.GetComponent<Bumper>();
        if (bumper != null)
        {
            print("ball collided with bumper.");
            bumper.Bump();

            // code to bump the ball
            theBall.AddForce(Vector3.up * launchForce, ForceMode.Impulse);
        }
    }
}
