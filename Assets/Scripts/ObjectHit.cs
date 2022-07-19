using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.tag == "Player")
        {
            // When u hit the wall (object/other), calor will be changed.
            GetComponent<MeshRenderer>().material.color = Color.black;
            // When u hit the other gameObj, tag will be changed; Untagged --> Hit.
            gameObject.tag = "Hit";
        }
    }
}