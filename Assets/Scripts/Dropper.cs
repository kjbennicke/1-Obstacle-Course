using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] int timeSec = 3;
    MeshRenderer render;
    Rigidbody grav;
    // Start is called before the first frame update
    void Start()
    {
        render = GetComponent<MeshRenderer>();
        grav = GetComponent<Rigidbody>();

        render.enabled = false;
        grav.useGravity = false;
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Time.time > timeSec){
            render.enabled = true;
            grav.useGravity = true;
        }
    }
}
