using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    public GameObject peanutdestroyer;
    [SerializeField] GameObject ballbounce;
    public bool popped = false;
    Ball red;

    // Start is called before the first frame update
    void Start()
    {
        // red = GetComponent<Ball>();
    }

    void Awake()
    {
        red = ballbounce.GetComponent<Ball>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Peanut(Clone)")
        {
            red.popgone();
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }


}
