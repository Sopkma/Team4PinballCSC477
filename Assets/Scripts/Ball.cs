using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody theBall;
    public float launchForce;
    //private int lives; // lec
    //private const int MAX_LIVES = 3; 

    public Menu menu;
    // Start is called before the first frame update
    void Start()
    {
    //    lives = MAX_LIVES;
        theBall = GetComponent<Rigidbody>();
    }

    public void Launch()
    {
        theBall.AddForce(Vector3.forward * launchForce, ForceMode.Impulse);
    }

    //public void Restart() {
    //    transform.position - GameObject.FindGameObjectsWithTag("BallStart").transform.position;
    //    theBall.velocity = Vector3.zero;
    //    lives = 3;
    //}

    public void OnCollisionEnter(Collision collision)
    {
        var bumper = collision.gameObject.GetComponent<Bumper>();
        if (bumper != null)
        {
            print("ball collided with bumper.");
            bumper.Bump();
            Game.Instance.AddScore(100);
            // code to bump the ball
            theBall.AddForce(Vector3.forward * launchForce, ForceMode.Impulse);
            print("ball has added force.");
        }
        else {
            if(collision.gameObject.tag.StartsWith("Flipper")) {
                Game.Instance.AddScore(10);
            }
        }
    }
}
