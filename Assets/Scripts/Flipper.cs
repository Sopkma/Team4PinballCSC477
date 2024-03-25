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

    void Start()
    {
        rb = GetComponent<Rigidbody>();
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

    public void Flip() {
        rb.AddForce(Vector3.forward * power, ForceMode.Impulse); // apply the force to move the flipper
    }
}
