using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roller : MonoBehaviour
{

    MeshRenderer renderer;
    Rigidbody rigidbody;

    SphereCollider collider;

    [SerializeField] float TimetoWait = 0;
    [SerializeField] float Disappear = 0;


    // Start is called before the first frame update
    void Start()
    {
        collider = GetComponent<SphereCollider>();
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
        if (Time.time > Disappear){
            renderer.enabled = false;
            collider.enabled = false;
        }
    }
}
