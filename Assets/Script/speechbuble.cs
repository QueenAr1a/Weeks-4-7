using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class speechbuble : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    Vector2 pos;
    Vector2 barrelPos = new Vector2(7.68f, 0.1f);
    Vector3 defaultScale = new Vector3(0.414f, 0.414f, 0.414f);
    // Update is called once per frame
    void Update()
    {
        pos = transform.position;
        if (pos.x >= barrelPos.x - 3 && pos.x <= barrelPos.x + 3 && pos.y >= barrelPos.y - 3 && pos.y <= barrelPos.y + 3)
        {
            transform.localScale = defaultScale;
        }
        else
        {
            transform.localScale = Vector3.zero;

        }
    }
}
