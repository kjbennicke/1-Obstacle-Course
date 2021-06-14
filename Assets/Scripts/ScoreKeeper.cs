using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    int hits = 0;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != "Hit" && other.gameObject.tag != "Ground")
        {
            hits++;
            Debug.Log("You have bumped into thing this many times: " + hits);
        }

    }
}
