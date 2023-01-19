using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    public GameObject peanutdestroyer;
    private boolean popped = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Peanut(Clone)")
        {
            popped = true;
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
