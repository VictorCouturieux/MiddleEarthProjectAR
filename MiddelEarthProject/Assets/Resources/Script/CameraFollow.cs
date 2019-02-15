using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Camera thisCamera;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = new Quaternion(
            thisCamera.transform.rotation.x,
            thisCamera.transform.rotation.y,
            thisCamera.transform.rotation.z,
            transform.rotation.w);
    }
}
