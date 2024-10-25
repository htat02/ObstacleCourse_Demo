using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision other)
    {
        // Check if the object hit has the tag "Wall"
        {

            if(other.gameObject.tag == "Player") {

            GetComponent<MeshRenderer>().material.color = Color.red;
            }
        }
    }
}
