using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;
    private void OnCollisionEnter(Collision other) 
    {
        // if the player hit smth that has already been hit, then don't increase our score.
        if (other.gameObject.tag != "Hit")
        {
            hits++; // hits = hits + 1;
            Debug.Log("You've bumped into a thing this many times: " + hits);
        }
    }
}