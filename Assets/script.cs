using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{
    private  Camera mainCamera;
    public float movingCamera ;
    private Vector3 lastposition;

    void Start()
    {
       // transform.position = new Vector3(lastposition.x, lastposition.y, lastposition.z);
        
       
        
    }

    // Update is called once per frame
    void Update()
    {
        

        transform.position = new Vector3(transform.position.x,
                                                         lastposition.y,
                                                         transform.position.z );

        lastposition.y -= movingCamera;
    }
}
