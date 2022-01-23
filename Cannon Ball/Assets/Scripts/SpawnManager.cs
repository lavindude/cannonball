using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject cube;
    private GameManager gameManager;
    private float spawnRange = 4.4f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnCubeRandomly", 0, 2);
        gameManager = GameObject.Find("GameManager")
            .GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameManager.gameActive)
        {
            CancelInvoke("SpawnCubeRandomly");
        }
    }

    void SpawnCubeRandomly()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRange, spawnRange), 10.5f, 1);
        Instantiate(cube, spawnPos, cube.transform.rotation);
    }

    public void SpawnCycle()
    {
        InvokeRepeating("SpawnCubeRandomly", 0, 2);
    }
}
