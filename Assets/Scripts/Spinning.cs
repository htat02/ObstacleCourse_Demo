using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinning : MonoBehaviour
{
    [SerializeField] float spinSpeed = 100f; // Speed of the spin in degrees per second

    void Update()
    {
        // Rotate the object around the y-axis
        transform.Rotate(0, spinSpeed * Time.deltaTime, 0);
    }
}
