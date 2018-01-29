using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {
    public float paddleSpeed = 1;
    private Vector3 playerPos = new Vector3(0, -7, 7);
	
	// Update is called once per frame
	void Update () {

        //input axis thats already defined in the input manager  by default in all unity projects
        //listens to the left and right input on the key board a and d keys and the joy stick on the horizontal axis
        float xPos = transform.position.x + Input.GetAxis("Horizontal") * paddleSpeed;
        Debug.Log(transform.position.x);

        playerPos = new Vector3(Mathf.Clamp(xPos, -7.7,  7.7), -7, 7);
        //playerPos = new Vector3(xPos, -6, 7);
        transform.position = playerPos;
	}
}
