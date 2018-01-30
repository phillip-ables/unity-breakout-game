using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour {
    //this is for the water where we made the collider a trigger
    void OnTriggerEnter()
    {
        GM.instance.LoseLife();
    }
}
