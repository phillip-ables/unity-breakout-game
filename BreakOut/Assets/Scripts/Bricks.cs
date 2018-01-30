using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bricks : MonoBehaviour {

    public GameObject brickParticle;

    //on clolision enter is called evertime an object gets hit by another collider
    void OnCollisionEnter (Collision other)
    {
        Instantiate(brickParticle, transform.position, Quaternion.identity);
        //we can call the destroy brick function from this bricks script because we set up our static instance of our game manager
        //its pretty handy;
        GM.instance.DestroyBrick();
        Destroy(gameObject);
    }
    
}
