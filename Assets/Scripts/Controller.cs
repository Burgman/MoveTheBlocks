using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{

    public Transform target;
    public Transform mainCameraTransform;

    public void OnGoButtonPressed() {
        Vector3 directionTemp = target.position - mainCameraTransform.position;
        directionTemp = directionTemp.normalized; 
        Debug.Log(directionTemp);
        Vector3 directionActual = new Vector3(Mathf.RoundToInt(directionTemp.x), 
                                              Mathf.RoundToInt(directionTemp.y), 
                                              Mathf.RoundToInt(directionTemp.z));

    }
  
}

public class ButtonID
{
    public const string FORWARD = "forward";
    public const string BACKWARD = "backward";
    public const string LEFT = "left";
    public const string RIGHT = "right";
    public const string UP = "up";
    public const string DOWN = "down";
}
