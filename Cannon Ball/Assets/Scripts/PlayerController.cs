using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject ball;
    public int speed = 100;
    public Vector3 startPos = new Vector3(-5.49f, -0.35f, 0.89f);

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
            ballPrefabRb.AddForce((mousePos - startPos).normalized * speed);
            Debug.Log(mousePos.x + " " + mousePos.y);
        }
    }
}
