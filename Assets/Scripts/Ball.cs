using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody theBall;
    public float launchForce;
    public float bumperForce;
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
            // I'm commenting out this AddSCore function because it currently does not work, and
            // it prevents the script from functioning properly.
            //Game.Instance.AddScore(100);

            // code to bump the ball

            //theBall.AddForce(new Vector3(-theBall.transform.position.x / 2f, theBall.transform.position.y, (-theBall.transform.position.z / 2f) + bumperForce) * bumperForce, ForceMode.Impulse);
            theBall.AddForce(Vector3.forward * bumperForce, ForceMode.Impulse);
            print("ball has added force.");
        }
        else {
            if(collision.gameObject.tag.StartsWith("Flipper")) {
                Game.Instance.AddScore(10);
            }
        }
    }
}
