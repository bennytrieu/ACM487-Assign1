using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class truckmove : MonoBehaviour
{
    public bool go = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (go == true)
        {
            transform.Translate(Vector3.right * Time.deltaTime * 5);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "watercooler")
        {
            go = true;
        }
    }
}
