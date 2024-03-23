using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roof : MonoBehaviour
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
        var theBall = other.gameObject.GetComponent<Rigidbody>();
        theBall.AddForce(new Vector3(0, -100, 0), ForceMode.Impulse);
        print("Hit roof. Pushing ball back to floor..");
    }
}
