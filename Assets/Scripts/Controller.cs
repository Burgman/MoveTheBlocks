using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

    public Transform target;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnButtonClick(string buttonID) {
        if (buttonID == ButtonID.FORWARD)
        {
            this.target.localPosition += Vector3.forward;
        }
        else if (buttonID == ButtonID.BACKWARD)
        {
            this.target.localPosition += Vector3.back;
        }
        else if (buttonID == ButtonID.LEFT)
        {
            this.target.localPosition += Vector3.left;
        }
        else if (buttonID == ButtonID.RIGHT)
        {
            this.target.localPosition += Vector3.right;
        }
        else if (buttonID == ButtonID.UP)
        {
            this.target.localPosition += Vector3.up;
        }
        else if (buttonID == ButtonID.DOWN)
        {
            this.target.localPosition += Vector3.down;
        }
    }
}

public class ButtonID {
    public const string FORWARD = "forward";
    public const string BACKWARD = "backward";
    public const string LEFT = "left";
    public const string RIGHT = "right";
    public const string UP = "up";
    public const string DOWN = "down";
}
