using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            other.GetComponent<Character>().Size += other.GetComponent<Character>().Size;
            Destroy(this);
        }
    }
}
