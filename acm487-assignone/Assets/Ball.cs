using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public bool popped = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void popgone()
    {
        Debug.Log("ree");
        popped = true;
        GetComponent<Rigidbody>().useGravity = true;
    }
}
