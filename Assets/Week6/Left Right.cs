using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftRight : MonoBehaviour
{
    Vector2 pos;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
        transform.position = pos;
     
        if (Input.GetKey(KeyCode.A))
        {
            pos.x -= 0.005f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            pos.x += 0.005f;
        }

    }
}
