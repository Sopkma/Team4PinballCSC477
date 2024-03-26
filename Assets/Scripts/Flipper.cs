using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

[RequireComponent(typeof(Rigidbody))]
public class Flipper : MonoBehaviour
{
    public Flipper leftFlipper;
    public Flipper rightFlipper;

    private Rigidbody rb;
    public float power;
    private AudioSource audioSrc;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        audioSrc = GetComponent<AudioSource>();
    }

    void Update() {

        var input = Game.Instance.input;
        if (input.Player.FlipperRight.WasPressedThisFrame()) {
            rightFlipper.Flip();
        }
        else if (input.Player.FlipperLeft.WasPressedThisFrame()) {
            leftFlipper.Flip();
        }
    }

    // original flip function
    /*
    public void Flip() {
        rb.AddForce(Vector3.forward * power, ForceMode.Impulse); // apply the force to move the flipper
    }
    */
    // edit for new flipper
    public void Flip()
    {
        rb.AddForce(Vector3.right * power, ForceMode.Impulse); // apply the force to move the flipper
        audioSrc.Play();
    }

}
