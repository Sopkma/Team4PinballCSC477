using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody theBall;
    public float launchForce;
    public float bumperForce;
    private int lives;
    private const int MAX_LIVES = 3;
    private bool canBeLaunched;

    public Menu menu;
    
    void Start()
    {
        lives = MAX_LIVES;
        theBall = GetComponent<Rigidbody>();

        canBeLaunched = true;
    }

    private void Update() {
        var input = Game.Instance.input;
        if (canBeLaunched && input.Player.BallLaunch.WasReleasedThisFrame()) {
            Launch();
        }
    }

    public void Launch()
    {
        float randomLaunch = Random.Range(launchForce * 0.7f, launchForce * 2.0f); // Randomizes the balls launch power
        theBall.AddForce(Vector3.forward * randomLaunch, ForceMode.Impulse);
        canBeLaunched = false;
    }

    public void ResetBall() {
        transform.position = GameObject.FindGameObjectWithTag("Ball Start").transform.position;
        theBall.velocity = Vector3.zero;

        lives--;
        print("lost a life");
        if (lives < 0) {
            menu.GameOver();
        } else {
            canBeLaunched = true;
        }
    }

    public void RestartGame() {
        transform.position = GameObject.FindGameObjectWithTag("Ball Start").transform.position;
        theBall.velocity = Vector3.zero;

        lives = MAX_LIVES;
        canBeLaunched = true;
    }

    public void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Ball End")) {
            ResetBall();
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        var bumper = collision.gameObject.GetComponent<Bumper>();
        if (bumper != null)
        {
            print("ball collided with bumper.");
            bumper.Bump();
            Game.Instance.AddScore(100);

            // code to bump the ball
            //theBall.AddForce(new Vector3(-theBall.transform.position.x / 2f, theBall.transform.position.y, (-theBall.transform.position.z / 2f) + bumperForce) * bumperForce, ForceMode.Impulse);
            theBall.AddForce(Vector3.forward * bumperForce, ForceMode.Impulse);
            print("ball has added force.");
        }
        else {
            if (collision.gameObject.tag.StartsWith("Flipper")) {
                Game.Instance.AddScore(10);
            }
        }
    }
}
