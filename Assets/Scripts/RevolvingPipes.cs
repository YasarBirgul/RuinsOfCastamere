using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class RevolvingPipes : MonoBehaviour
{    // Pipe Components
    [SerializeField] public GameObject thePipe_;
    // Pipe Rotation Speed
    [SerializeField] public float pipeRotationSpeed=5;
    // Pipe Transform info
    [SerializeField] public Transform pipeTransformData;
    
    // Start is called before the first frame update
    void Start()
    {
        pipeTransformData = GetComponent<Transform>();

    }

    // Rotation of the pipe by accelerator ınput
    void Update()
    {
        pipeTransformData.transform.Rotate(Input.acceleration.x*pipeRotationSpeed, 0, 0, Space.World);
    }
  
    // Endless Pipe Generator
    private void OnTriggerEnter(Collider other)
    { 
        // thePipe_.transform.position = new Vector3(pipeTransformData.transform.localScale.y*(-4) + thePipe_.transform.position.x , 0, 0);
        thePipe_.transform.position =
            new Vector3(pipeTransformData.transform.lossyScale.y*(-4) + thePipe_.transform.position.x,0,0);
    }
}
