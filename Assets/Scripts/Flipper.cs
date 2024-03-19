using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Flipper : MonoBehaviour
{
    private Rigidbody rb;
    public float power;

    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
    }

    public void flip() {
        rb.AddForce(Vector3.forward * power, ForceMode.Impulse); // apply the force to move the flipper
    }
}
