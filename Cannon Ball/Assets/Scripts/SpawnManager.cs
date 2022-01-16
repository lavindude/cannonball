using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject cube;
    private float spawnRange = 4.4f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnCubeRandomly", 0, 2);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnCubeRandomly()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRange, spawnRange), 10.5f, 1);
        Instantiate(cube, spawnPos, cube.transform.rotation);
    }
}
