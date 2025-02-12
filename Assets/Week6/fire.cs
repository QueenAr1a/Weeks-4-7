using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour
{
    
    public bool isFired = false;
    public float speed = 5;
    // Update is called once per frame
    void Update()
    {
        if(isFired)
        {
            transform.position += Vector3.up * speed * Time.deltaTime;


        }
        else
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 direction = mousePos - (Vector2)transform.position;
            transform.up = direction;
        }
    }
    public void Drop()
    {
        transform.parent = null;
        Destroy(gameObject, 5);
    }

    public void Fire()
    {
        isFired = true;
        transform.parent = null;
        Destroy(gameObject, 5);
    }
}
