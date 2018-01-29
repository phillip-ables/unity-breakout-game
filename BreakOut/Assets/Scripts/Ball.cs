using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    public float ballInitialVel = 600f;
    private RigidBody rb;

	// Like start but before start
	void Awake () {
        rb = GameComponent<Rigidbody>;
;	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
