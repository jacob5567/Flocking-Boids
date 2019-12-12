using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoidScript : MonoBehaviour
{
    private Rigidbody rb;
    public float viewRadius = 10f;
    public bool isMain = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * 15f;
    }

    // Update is called once per frame
    void Update()
    {
        visionRadius();
        LoopAroundArea();
    }

    private void LoopAroundArea()
    {
        float x, y, z;
        if (transform.position.x > 100)
            x = 0;
        else if (transform.position.x < 0)
            x = 100;
        else
            x = transform.position.x;
        if (transform.position.y > 100)
            y = 0;
        else if (transform.position.y < 0)
            y = 100;
        else
            y = transform.position.y;
        if (transform.position.z > 100)
            z = 0;
        else if (transform.position.z < 0)
            z = 100;
        else
            z = transform.position.z;

        transform.position = new Vector3(x, y, z);
    }

    private void visionRadius()
    {
        Collider[] otherColliders = Physics.OverlapSphere(transform.position, viewRadius);
        List<Collider> seenColliders = new List<Collider>();
        foreach (Collider c in otherColliders)
        {
            if(Vector3.Angle(transform.forward, c.transform.position) < 135f)
            {
                seenColliders.Add(c);
            }
        }
    }
}
