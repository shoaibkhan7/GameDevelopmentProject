using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider_lab : MonoBehaviour
{
    MeshRenderer meshRenderer;
    Color color;
    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        color = meshRenderer.material.color;
    }

    void OnCollisionEnter(Collision other){
        GameObject go = other.gameObject;
        if(go.CompareTag("car")){
            meshRenderer.material.color = Color.red;
        }
    }
    void OnCollisionExit(Collision other){
        GameObject go = other.gameObject;
        if(go.CompareTag("car")){
            meshRenderer.material.color = color;
        }
    }
}
