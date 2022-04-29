using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public class RevolvingPipes : MonoBehaviour
{
    //// Pipe Components ////


    // Pipe Rotation Speed
    [SerializeField] public float pipeRotationSpeed = 5;

    // Pipe Transform info
    [SerializeField] public Transform pipeTransformData;

    public float positionX;




    /// Pipe Spawner Components
    ///
    private float spawnPlatTo;

    private int randomInt;

    // Randomizer Float
    private float platformNumber;

    private Vector3 platformSpawnPoint;

    // Pipe Type list
    [SerializeField] public Quaternion rotation = Quaternion.identity;
    public GameObject[] spawnPipePlatforms;


    // Catching...
    void Start()
    {
        pipeTransformData = GetComponent<Transform>();

    }

    // Rotation of the pipe by accelerator ınput
    void Update()
    {
        pipeTransformData.transform.Rotate(Input.acceleration.x * pipeRotationSpeed, 0, 0, Space.World);
    }

    // Endless Pipe Generator
       private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            spawnRandomPipes();
        }

       
    }
 void spawnRandomPipes()
        {
            
            randomInt = Random.Range(0, spawnPipePlatforms.Length);
            Instantiate(spawnPipePlatforms[randomInt], platformSpawnPoint, Quaternion.identity);
            Destroy(gameObject);
            positionX -= 100;
            platformSpawnPoint = new Vector3(positionX, 0, 0);
            
            Debug.Log(positionX);
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
        
    

