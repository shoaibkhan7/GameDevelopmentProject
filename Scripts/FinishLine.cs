using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("car")){
            Debug.Log("Yay! You've reached the finish line 🎉");
        }
    }
    
}
