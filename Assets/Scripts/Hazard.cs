using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            other.GetComponent<Character>().Size -= other.GetComponent<Character>().Size;
            Debug.Log("yo");
        }
    }
}
