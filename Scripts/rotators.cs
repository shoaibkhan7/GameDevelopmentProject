using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotators : MonoBehaviour
{
    [SerializeField]
    float rotate_y_axis = 100f;

    // Update is called once per frame
    void Update()
    {
        float finalRotate = rotate_y_axis * Time.deltaTime;
        transform.Rotate(0,finalRotate,0);
    }
}
