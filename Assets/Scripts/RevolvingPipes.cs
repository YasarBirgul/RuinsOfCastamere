using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;
public class RevolvingPipes : MonoBehaviour
{   //// Pipe Components ////
    // Pipe Rotation Speed
    [SerializeField] public float pipeRotationSpeed = 5;
    // Pipe Transform info
    [SerializeField] public Transform pipeTransformData;
    /// Pipe Spawner Components
    private float spawnPlatTo;
    private int randomInt;
    // Randomizer Float
    private float platformNumber;
    private Vector3 platformSpawnPoint;
    // Pipe Type list
    [SerializeField] public Quaternion rotation = Quaternion.identity;
    public GameObject[] spawnPipePlatforms;
   
    
    
    // Catching...
    void Start() {
      
        
        
        pipeTransformData = GetComponent<Transform>();
    }  
    // Rotation of the pipe by accelerator ınput
    void Update() {
        
        
        
        
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
    {   randomInt = Random.Range(0, spawnPipePlatforms.Length);
            platformSpawnPoint = new Vector3(gameObject.transform.position.x-200, 0, 0);
            Instantiate(spawnPipePlatforms[randomInt], platformSpawnPoint,rotation);
            Destroy(gameObject);
    } 
} 