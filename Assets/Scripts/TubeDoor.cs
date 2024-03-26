using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TubeDoor : MonoBehaviour
{
    private GameObject door;
    // Start is called before the first frame update
    void Start()
    {
        door = GameObject.FindGameObjectWithTag("Tube Door");
        door.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        door.SetActive(true);
    }
}
