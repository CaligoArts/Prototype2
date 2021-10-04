using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
    //Controls how often a projectile can be launched: (Basically a FireRate CoolDown Controller.)
{
    public GameObject dogPrefab;

    //Fire Rate Variables:
    private float fireRate = 1; //Time the player has to wait to fire again
    private float nextFire = 0;     //Time since start after which player can fire again.

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, if enough time has elapsed since last fire, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextFire)    //Checks if spacebar pressed and if game time passed is greater than the nextFire variable.
            //Time.time is the time in seconds since the game started.
        {
            nextFire = Time.time + fireRate;    //Resets nextFire to current time + fireRate
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);   //Creates a copy of dogPrefab & sends it on screen based on it's rotation.
        }
    }
}
