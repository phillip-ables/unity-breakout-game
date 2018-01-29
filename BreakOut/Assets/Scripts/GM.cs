﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GM : MonoBehaviour {
    public int lives = 3;
    public int bricks = 24;
    public float resetDelay = 1f;
    public Text livesText;
    public GameObject gameOver;
    public GameObject youWin;
    public GameObject bricksPrefab;
    public GameObject paddle;
    public GameObject deathParticles;
    //instance a static variable we access it through the class not through an instance of the class
    //use this in conjuntion with what is called a singleton pattern,
    //meaning there is only ever going to be one instance of the game manager availible
    public static GM instance = null;

    private GameObject clonePaddle;

	// Use this for initialization
	void Start () {
        //enforce that singleton pattern
        if (instance == null)
            instance = this;
        else if (instance != tmerhis)
            Destroy(gameObject);

        Setup();
	}

    public void Setup()
    {
        clonePaddle = Instantiate(paddle, transform.position, Quaternion.identity) as GameObject;
        Instantiate(bricksPrefab, transform.position, Quaternion.identity);
    }
	
	// Update is called once per frame
	void Update () {

	}
}
