using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {
    public float paddleSpeed = 1;
    private Vector3 playerPos = new Vector3(0, -6, 7);
	
	// Update is called once per frame
	void Update () {
        float xPos = transform.position.x + Input.GetAxis("Horizontal") * paddleSpeed;
        playerPos = new Vector3(Mathf.Clamp(xPos, 8f, -8f), -6, 7);
        transform.position = playerPos;
	}
}
