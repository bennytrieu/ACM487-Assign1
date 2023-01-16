using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeanutFly : MonoBehaviour
{
    private float speed = 10.0f;
    private float peanutdecay = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, peanutdecay);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * speed);
    }
}
