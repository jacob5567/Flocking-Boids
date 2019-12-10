using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlockGenerator : MonoBehaviour
{
    public GameObject BoidPrefab;
    public int numBoids;
    private List<GameObject> boidsList = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numBoids; i++)
        {
            boidsList.Add(Instantiate(BoidPrefab, new Vector3(Random.Range(0, 100),
                Random.Range(0, 100), Random.Range(0, 100)), Random.rotation));
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
