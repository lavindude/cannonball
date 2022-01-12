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
        if (transform.position.y < -1.25)
        {
            Destroy(gameObject);
        }
    }
}
