using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoidScript : MonoBehaviour
{
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = Vector3.forward * 5f;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
