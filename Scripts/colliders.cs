using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliders : MonoBehaviour
{
    MeshRenderer meshRenderer;
    Color OrignalColor; 
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        OrignalColor = meshRenderer.material.color; 
    }

    void OnCollisionEnter(Collision other) {
        if(other.gameObject.CompareTag("car")){
            meshRenderer.material.color = Color.red;
        }
    }
    void OnCollisionExit(Collision other) {
        if(other.gameObject.CompareTag("car")){
            meshRenderer.material.color = OrignalColor;
        }
    }
}
