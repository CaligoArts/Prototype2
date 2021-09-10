﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    //Fire Rate Variables:
    private float fireRate = 1; //Time the player has to wait to fire again
    private float nextFire = 0;     //Time since start after which player can fire again.

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
