using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30;    //Sets top boundary at 30.
    private float lowerBound = -10;     //Sets bottom boundry at -10.

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)    //Checks if position on z axis is greater than top boundry variable.
        {
            Destroy(gameObject);    //Destroys game object if goes past top boundry.
        }
        else if (transform.position.z < lowerBound)     //Check if position on z axis is less than bottom boundry variable.
        {
            Destroy(gameObject);    //Destroys game object if goes past bottom boundry.
            Debug.Log("Game Over!");    //Displays Game Over! in console if object goes beyond boundries set.
        }
    }
}
