using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    public float ballInitialVel = 600f;
    //public GameObject ball;
    private Rigidbody rb;
    //rb = GameComponent<Rigidbody>;
    private bool ballInPlay;

    //it lightbulbed this
    //public RigidBody Rb { get => rb; set => rb = value; };


    // Like start but before start
    void Awake () {
        rb = GetComponent<Rigidbody>();
;	}
	
	// Update is called once per frame
	void Update () {
        //rb = GameComponent<Rigidbody>;

        if (Input.GetButtonDown("Fire1") && ballInPlay == false)
        {
            transform.parent = null;
            ballInPlay = true;
            rb.isKinematic = false;
            rb.AddForce(new Vector3(ballInitialVel, ballInitialVel, 7));
        }
    }
}
