using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{

    public float rotationSpeed;
    public float rotationRatio;

    public Transform pivotObject;

    bool isRotating;
    Vector3 mousePosition;
    int rotationDirectionY;
    int rotationDirectionX;
    // Use this for initialization
    void Start()
    {
        this.isRotating = false;
        this.rotationDirectionY = 0;
        this.rotationDirectionX = 0;
    }

    private void OnMouseDrag()
    {
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.isRotating = true;
            this.mousePosition = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            this.isRotating = false;
        }
        else
        {
            if (isRotating)
            {
                this.doRatation();

            }

        }

    }

    void doRatation()
    {

        float rotationX = Input.GetAxis("Mouse X") * rotationSpeed * Mathf.Deg2Rad;
        float rotationY = Input.GetAxis("Mouse Y") * rotationSpeed * Mathf.Deg2Rad;

        if (this.tag == Tag.CameraDollingTag)
        {
            this.transform.RotateAround(pivotObject.position, Vector3.up, rotationX);

            this.transform.RotateAround(pivotObject.position, Vector3.right, -rotationY);
        }
        else
        {

            this.transform.RotateAround(pivotObject.position, Vector3.up, -rotationX);
            this.transform.RotateAround(pivotObject.position, Vector3.right, rotationY);
        }

    }
}

public class Tag
{
    public const string CameraDollingTag = "CameraDolling";

}