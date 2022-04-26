using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevolvingPipes : MonoBehaviour
{
    [SerializeField] public Transform rotation_;
    
    
    // Start is called before the first frame update
    void Start()
    {
        rotation_ = GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        rotation_.transform.Rotate(Input.acceleration.x*5, 0, 0, Space.World);
    }
    
}
