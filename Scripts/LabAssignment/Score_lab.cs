using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score_lab : MonoBehaviour
{
    int score = 0;
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.CompareTag("walls")){
            score++;
        }    
    }

    public int getScore() {
        return score;
    }

}
