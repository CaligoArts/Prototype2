using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //*Create an Empty GameObject in Editor to attach SpawnManager script to with the same name.

    //Define which animal prefab spawns:
    public GameObject[] animalPrefabs;  //Allows assigning of an Array of GameObjects in Inspector.
    //public int animalIndex;     //Interger variable to use as a number value for which prefab is spawned. 0 spawns first prefab game object in array, 1 spawns 2nd in array, 2 spawns 3rd in array, & so on.
    //Removed Global variable because it's only needed locally in the if() statement below. Meaning nothing else needs to make use of the variable anywhere else in the script.

    //Define location of prefab spawns:
    private float spawnRangeX = 20;     //Sets spawn range on x axis to 20.
    private float spawnPosZ = 20;       //Sets position of where to spawn on z axis to 20.

    //Timer control variables to spawn on a timer:
    private float startDelay = 2;   //Delays spawn in seconds from after scene starts when used in start method. 
    private float spawnInterval = 1.5f;     //Tells it how often to spawn once started.

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);    //Calls SpawnRandomAnimal() at start of scene based on startDelay variable and then spawns at intervals set by variable.
    }

    // Update is called once per frame
    void Update()
    {
        //*Commented all of this code out so it uses InvokeRepeating in Start() to spawn on a timer instead of a key press.
        //if (Input.GetKeyDown(KeyCode.S))    //Checks if S key is pressed.
        //{
            //*Copied & pasted all this code to create a custom method for SpawnRandomAnimal() so commented it out here to show changes:
            //Randomly generate animal index & spawn location:
            //Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);  //Spawns prefab at random range on x axis while keeping y & z axis position the same.
            //int animalIndex = Random.Range(0, animalPrefabs.Length);    //Generates a random number from 0 to the total number of prefabs in the array so it spawns either of the 3 prefab game objects.
            //Random.Range() method gives a random number within the range specified inside the () for example (0,100) would give a random number between 1 and 100 like 58 and differ each time called.

            //Instantiate(animalPrefabs[animalIndex], new Vector3(0, 0, 20), animalPrefabs[animalIndex].transform.rotation);  //Spawns a new animalprefab at the top of the screen when S key is pressed based on prefabs rotation.
            //Replaced hardcoded Vector3 with variable.
            //Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);   //Uses spawnPos variable set above to spawn at random locations.

            //SpawnRandomAnimal();    //Calls the custom method Written below.
        //}
    }

    void SpawnRandomAnimal()
    {
        //*Copied code from above:
        //Randomly generate animal index & spawn location:
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);  //Spawns prefab at random range on x axis while keeping y & z axis position the same.
        int animalIndex = Random.Range(0, animalPrefabs.Length);    //Generates a random number from 0 to the total number of prefabs in the array so it spawns either of the 3 prefab game objects.
                                                                    //Random.Range() method gives a random number within the range specified inside the () for example (0,100) would give a random number between 1 and 100 like 58 and differ each time called.

        //Instantiate(animalPrefabs[animalIndex], new Vector3(0, 0, 20), animalPrefabs[animalIndex].transform.rotation);  //Spawns a new animalprefab at the top of the screen when S key is pressed based on prefabs rotation.
        //Replaced hardcoded Vector3 with variable.
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);   //Uses spawnPos variable set above to spawn at random locations.
    }
}
