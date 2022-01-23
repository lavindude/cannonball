using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCannon : MonoBehaviour
{
    public GameObject cameraObject;
    private float tunedCameraZSpot = 20.4f;

    private float cannonXPosition = -5.52f;
    private float cannonYPosition = 0.5168f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = cameraObject.GetComponent<Camera>().ScreenToWorldPoint(new 
                    Vector3(Input.mousePosition.x,
                    Input.mousePosition.y, tunedCameraZSpot));
        Vector3 rotation = new Vector3(0, 0, calculateZRotation(mousePos.x, mousePos.y));
        gameObject.transform.eulerAngles = rotation;
    }

    public float calculateZRotation(float mousePosX, float mousePosY)
    {
        float deltaY = Mathf.Abs(mousePosY - cannonYPosition);
        float deltaX = Mathf.Abs(mousePosX - cannonXPosition);

        //theta is in radians
        float theta = Mathf.Atan2(deltaY, deltaX);
        float alpha = (Mathf.PI / 2.0f) - theta;

        return -1 * alpha * Mathf.Rad2Deg;
    }
}
