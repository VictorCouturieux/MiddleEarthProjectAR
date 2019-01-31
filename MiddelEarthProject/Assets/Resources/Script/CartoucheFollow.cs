using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CartoucheFollow : MonoBehaviour
{

    public Transform cartouche;
//    private Quaternion offQ;
    
    // Start is called before the first frame update
    void Start()
    {
//        offQ = new Quaternion(
//            transform.rotation.x - cartouche.transform.rotation.x,
//            transform.rotation.y - cartouche.transform.rotation.y,
//            transform.rotation.z - cartouche.transform.rotation.z,
//            transform.rotation.w - cartouche.transform.rotation.w
//        ); 
    }

    // Update is called once per frame
    void Update()
    {
        cartouche.rotation = new Quaternion(
            transform.rotation.x -90,
            transform.rotation.y  ,
            transform.rotation.z,
            transform.rotation.w);
    }
}
