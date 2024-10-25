using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] float hit = 0;

    private void OnCollisionEnter(Collision other) {
        hit++;
        Debug.Log("Bumped into a wall");
    }
}
