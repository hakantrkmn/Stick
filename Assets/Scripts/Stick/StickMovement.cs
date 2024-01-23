using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickMovement : MonoBehaviour
{

    public float rotationSpeed;
    float screenXMiddlePoint
    {
        get { return Screen.width / 2; }
    }


    void Update()
    {
        Movement();
    }


    void Movement()
    {
        if (Input.GetMouseButton(0))
        {
            var touchPosX = Input.mousePosition.x;

            if (touchPosX > screenXMiddlePoint)
            {
                transform.Rotate(new Vector3(0, 0, -1) * Time.deltaTime * rotationSpeed);
            }
            else
            {
                transform.Rotate(new Vector3(0, 0, 1) * Time.deltaTime * rotationSpeed);

            }
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(new Vector3(0, 0, 1) * Time.deltaTime * rotationSpeed);

        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0, 0, -1) * Time.deltaTime * rotationSpeed);

        }

    }
}
