using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinnerToo : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]float xRotation = 0f;
    [SerializeField]float yRotation = 0f;
    [SerializeField]float zRotation = 0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xRotation, yRotation, zRotation);
    }
}
