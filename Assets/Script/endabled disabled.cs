using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endableddisabled : MonoBehaviour
{
    public SpriteRenderer sr;
    public endableddisabled script;
    public GameObject go;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetMouseButton(0)) 
        {
            //script.enabled = false;
            //sr.enabled = false;
            go.SetActive(false);
        }

         if (Input.GetKeyDown(KeyCode.Space))
        {
            //script.enabled = true;
            //sr.enabled = true;
            go.SetActive(true);
        }
    }
}
