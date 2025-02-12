using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    Vector2 pos;
    int t = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A) ||Input.GetKey(KeyCode.D))
        {
            t++
                if (t / 2 == 0)
                pos.y += 0.005f;
        }
    }
}
