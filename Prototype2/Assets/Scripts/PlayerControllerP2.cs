using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerP2 : MonoBehaviour
{
    public float horizontalInput;   //Variable to track user input left/ right.
    public float speed = 10.0f;     //Controls speed that the input moves left or right.
    public float xRange = 10;       //Range of movement on the x axis to replace hardcoded values.

    public GameObject projectilePrefab;     //Allows setting of a GameObject to be a projectile in the Inspector for the player.

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");  //Assigns variable to Input manager horizontal Axis in Unity Editor.
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);  //Moves player left/ right based on user input times 1 second times speed set in variable.

        //Create Boundry for the player movement left to right:
        //if (transform.position.x < -10)     //Checks if players x position is less than -10 (to the left side of screen)
        if (transform.position.x < -xRange)     //Removed & replaced hardcoded value with variable.
        {
            //transform.position = new Vector3(-10, transform.position.y, transform.position.z);  //Sets player position  to its current position with a fixed x location so can't go past -10 on the x axis.
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);  //Removed & replaced hardcoded value with variable.
        }

        //if (transform.position.x > 10)      //Checks if player x position is greater than 10 (to right side of screen)
        if (transform.position.x > xRange)  //Removed & replaced hardcoded value with variable.
        {
            //transform.position = new Vector3(10, transform.position.y, transform.position.z);   //Stops player if goes past 10 on x axis.
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);   //Removed & replaced hardcoded value with variable.
        }

        //Launch a projectile when spacebar is pressed:
        if (Input.GetKeyDown(KeyCode.Space))    //Checks if Spacebar has been pressed.
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);     //Launches copy of projectilePrefab from players current position based on prefabs rotation.
            //Instantiate() method creates a copy of a GameObject.
        }
    }
}
