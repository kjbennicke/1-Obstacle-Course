using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] int timeSec = 3;
    MeshRenderer dropperRenderer;
    Rigidbody dropperRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        dropperRenderer = GetComponent<MeshRenderer>();
        dropperRigidbody = GetComponent<Rigidbody>();

        dropperRenderer.enabled = false;
        dropperRigidbody.useGravity = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeSec)
        {
            dropperRenderer.enabled = true;
            dropperRigidbody.useGravity = true;
        }
    }
}
