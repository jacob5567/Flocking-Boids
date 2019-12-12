using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlockGenerator : MonoBehaviour
{
    public GameObject BoidPrefab;
    public int numBoids;
    private List<GameObject> flock = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numBoids; i++)
        {
            GameObject newBoid = Instantiate(BoidPrefab, new Vector3(Random.Range(0, 100),
                Random.Range(0, 100), Random.Range(0, 100)), Random.rotation);
            flock.Add(newBoid);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
