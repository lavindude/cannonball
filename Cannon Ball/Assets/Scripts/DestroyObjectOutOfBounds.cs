using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjectOutOfBounds : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -1.25 || transform.position.x > 5.7 ||
            transform.position.y > 10.7 || transform.position.x < -7.7)
        {
            Destroy(gameObject);
        }
    }
}
