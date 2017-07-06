using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleRotation : MonoBehaviour {

    public float rotationSpeed;
    public float rotationRatio;

    bool isRotating;
    Vector3 mousePosition;
    // Use this for initialization
    void Start() {
        this.isRotating = false;
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetMouseButtonDown(0))
        {
            this.isRotating = true;
            this.mousePosition = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            this.isRotating = false;
        }
        else {
            if (isRotating) {
                this.doRatation();

            }

        }

    }

    void doRatation() {
        Vector3 oldMousePosition = mousePosition;
        mousePosition = Input.mousePosition;
        Vector3 rotationDelta = (mousePosition - oldMousePosition) * this.rotationRatio;
        
        this.transform.Rotate(rotationDelta  * this.rotationSpeed * Time.deltaTime);
    }
}
