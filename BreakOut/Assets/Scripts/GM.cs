using System.Collections;
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

    void CheckGameOver()
    {
        if (bricks < 1)
        {
            youWon.SetActive(true);
            //totally cosmetic just for fun
            Time.timeScale = .25f;
            //Invoke allows you to call a function with a delay
            Invoke("Reset", resetDelay);
        }
        if (lives < 1)
        {
            gameOver.SetActive(true);
            Time.timeScale = .25f;
            Invoke("Reset", resetDelay);
        }
    }

    void Reset()
    {
        //go back to normal time
        Time.timeScale = 1f;
        //we use the load level to load scenes this time its the last loaded level
        Application.LoadLevel(Application.loadedLevel);
    }

    public void LoseLife()
    {
        lives--;
        livesText.text = "Lives: " + lives;
        //instanctiate death particles at position of clone paddle
        Instantiate(deathParticles, clonePaddle.tranform.position, Quaternion.identity);
        Destroy(clonePaddle);
        invoke("SetupPaddle", resetDelay);
        CheckGameOver();
    }

    void SetupPaddle()
    {
        clonePaddle = Instantiate(paddle, transform.position, Quaternion.identity) as GameObject;
    }

    public void DestryBrick()
    {
        bricks--;
        CheckGameOver();
    }
    //delet update because were not using it
}
