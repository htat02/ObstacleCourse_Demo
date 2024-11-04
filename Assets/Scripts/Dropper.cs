using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{

    MeshRenderer renderer;
    Rigidbody rigidbody;

    BoxCollider collider;

    [SerializeField] float TimetoWait = 0;

    // Start is called before the first frame update
    void Start()
    {
        collider = GetComponent<BoxCollider>();
        renderer = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();

        renderer.enabled = false;
        rigidbody.useGravity = false;
        collider.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > TimetoWait) {
            renderer.enabled = true;
            rigidbody.useGravity = true;
        }

        if (Time.time > TimetoWait) {
            collider.enabled = true;
        }

    }
}
