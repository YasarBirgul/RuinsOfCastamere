using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    private Camera _cam;
    public GameObject player;
    
    
    // Start is called before the first frame update
    void Start()
    {
        _cam = GetComponent<Camera>();
        _cam= Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
     
    }
    
    
    private void LateUpdate()
    {
        _cam.transform.position = new Vector3(player.transform.position.x+2,0, 0);
    }
}
