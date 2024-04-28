using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int Score;
    void OnCollisionEnter(Collision other){
        GameObject Go = other.gameObject;
        if(Go.CompareTag("balls") || Go.CompareTag("obstacle") || Go.CompareTag("walls") || Go.CompareTag("box")){
            Score++;
            Debug.Log("Score: "+ Score);
        }
        // if(Go.CompareTag("balls")){
        //     Destroy(Go,2f);
        // }
    }
}
