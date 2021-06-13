using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]int moveSpeed = 10;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
      rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        // float zValue =  Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        // transform.Translate(xValue, 0, zValue);

        rb.AddRelativeForce(Vector3.forward * moveSpeed);
    }
}