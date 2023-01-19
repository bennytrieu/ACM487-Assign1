using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform endMarker = null;
    public float slow = 20;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // transform.position = transform.position + new Vector3(1, 0, 0);
        transform.position = Vector3.Lerp(transform.position, endMarker.position, Time.deltaTime/slow);
    }
}
