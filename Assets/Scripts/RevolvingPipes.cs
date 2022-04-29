using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public class RevolvingPipes : MonoBehaviour
{   //// Pipe Components ////
    
    // Pipe Rotation Speed
    [SerializeField] public float pipeRotationSpeed=5;
    // Pipe Transform info
    [SerializeField] public Transform pipeTransformData;


    
    public Quaternion rotation = Quaternion.identity;
    /// Pipe Spawner Components
    ///
    private float spawnPlatTo;
    
    // Randomizer Float
    private float platformNumber;

    private Vector3 platformLenght;
    // Pipe Types
    
    
    
    [SerializeField] public GameObject regular;
    [SerializeField] public GameObject SeconderPipe;
    
    
    
    // Catching...
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
        //  thePipe_.transform.position = new Vector3(pipeTransformData.transform.lossyScale.y*(-4) + thePipe_.transform.position.x,0,0); 
        platformNumber = Random.Range(1, 3);
        platformLenght = new Vector3(pipeTransformData.transform.lossyScale.y*-4 + gameObject.transform.position.x,0,0);

        if (other.CompareTag("Player"))
        {
            if(platformNumber == 1) {
                         
                Instantiate( regular, platformLenght,rotation);
               

            } 
            if(platformNumber == 2)
            {
                Instantiate(SeconderPipe,platformLenght,rotation);
                
            }
                     
                     
                     
        }
      
      
      
      
    } 
    
}
    
    //void PipeSpawner(float floatValue)
 // { 
 //      
 //     float y = spawnPlatTo;
 //      
 //     while (y <= floatValue) {
 //         platformNumber = Random.Range(1, 3);
 //       
 //       
 //         Vector3 posXY = new Vector3(Random.Range(-3.25f, 3.25f), y,0);
 //   
 //         if(platformNumber == 1) {
 //             Instantiate(regular,posXY,quaternion.identity);
 //      
 //         } 
 //         if(platformNumber == 2)
 //         {
 //             Instantiate(SeconderPipe, posXY,quaternion.identity);

 //         }
 //   
 //         y += Random.Range(1.9f, 2.1f);
 //     } spawnPlatTo = floatValue;  
 //   
        
    

