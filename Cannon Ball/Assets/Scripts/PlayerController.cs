using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject ball;
    public Vector3 startPos = new Vector3(-5.49f, -0.35f, 0.89f);

    private GameObject cameraObject;
    private int speed = 400;

    // Start is called before the first frame update
    void Start()
    {
        cameraObject = GameObject.Find("Main Camera");
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
            Vector3 mousePos = cameraObject.GetComponent<Camera>().ScreenToWorldPoint(new Vector3(Input.mousePosition.x, 
                Input.mousePosition.y, cameraObject.transform.position.z));
            ballPrefabRb.AddForce((mousePos - startPos).normalized * speed);
            Debug.Log(mousePos.x + " " + mousePos.y + " " + mousePos.z);
        }
    }
}
