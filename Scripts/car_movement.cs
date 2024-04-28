using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car_movement : MonoBehaviour
{
    [SerializeField]
    float Speed = 0.3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move() {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");
        float timebtwframe = Time.deltaTime;
        float x_move = Speed * horizontal * timebtwframe;
        float z_move = Speed * vertical * timebtwframe;
        transform.Translate(x_move,0,z_move);

    }
}
