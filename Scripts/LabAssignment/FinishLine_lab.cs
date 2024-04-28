using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSystem : MonoBehaviour
{
    int balls_count = 0;
    
    void OnTriggerEnter(Collider other) {
        if(balls_count == 2){
            Score_lab sc = FindObjectOfType<Score_lab>();
            Debug.Log("Game Finished! Your Score: "+sc.getScore());
        }
        if(other.gameObject.CompareTag("balls")){
            balls_count++;
        } 
    }
    void OnTriggerExit(Collider other) {
        if(other.gameObject.CompareTag("balls")){
        balls_count--;    
        }
    }
}
