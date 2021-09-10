using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)     //Built in method in MonoBehaviour class to detect collisions.
        //Attach this script to anything that collides with something else and makes something happen on collision.
        //Make sure to add colliders with Is Trigger checked to all game objects that will be effected when hit by something so it knows to test if something hits it.
        //Also make sure to add a rigidbody to your projectile so it detects the collision with physics.
    {
        Destroy(gameObject);    //Destroys game object that script is attached to when hit by another collider.
        Destroy(other.gameObject);  //Destroys game object that hit it. (Whatever other game objects collider hits it.)
    }
}
