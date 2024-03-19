using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody theBall;
    private float launchForce = 30;
    // Start is called before the first frame update
    void Start()
    {
        theBall = GetComponent<Rigidbody>();
    }

    public void Launch()
    {
        theBall.AddForce(Vector3.forward * launchForce, ForceMode.Impulse);
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
