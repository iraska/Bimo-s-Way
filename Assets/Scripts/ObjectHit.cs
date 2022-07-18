using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) 
    {
        // When u hit the wall, calor will be changed.
        GetComponent<MeshRenderer>().material.color = Color.black;
    }
}
