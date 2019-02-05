using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class TestRayCastToSelectionFlag : MonoBehaviour
{
    private float range = 10000000.0f;
    public Camera vuforiaCamera;
    private Collider coll;
    
    // Start is called before the first frame update
    void Start()
    {
        coll = GetComponent<Collider>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = vuforiaCamera.ScreenPointToRay(Input.mousePosition);
           
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 10000000.0f))
            {
                if (hit.transform == transform)
                {
                    Debug.Log("detect " + hit.transform.name);
                }
            }

        }   
    }
}
