using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField]
    float MyTime = 3f;
    Rigidbody rigidBody;
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        rigidBody.useGravity = false;
    }

    void Update()
    {
        if(Time.time > MyTime){
            rigidBody.useGravity = true;
        }
    }
}
