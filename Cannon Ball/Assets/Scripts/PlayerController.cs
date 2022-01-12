using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject ball;
    private int speed = 50;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SpawnBall();
    }

    void SpawnBall()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject ballPrefab = Instantiate(ball, transform.position, transform.rotation);
            Rigidbody ballPrefabRb = ballPrefab.GetComponent<Rigidbody>();
            Vector3 mousePos = Input.mousePosition;
            ballPrefabRb.AddForce((mousePos - transform.position).normalized * speed);
            //Debug.Log(mousePos.x);
        }
    }
}
