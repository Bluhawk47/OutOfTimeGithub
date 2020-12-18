using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnmanager : MonoBehaviour
{
    // attach the falling object prefab
    public GameObject[] debrisPrefab;

    //attach the player prefab
    public GameObject player;

    public int debrisIndex;

    // the range in the X axis of where the object will spawn
    float spawnRangeX = 7;

    //offset of what y position where the object will spawn, Y spawn position will be calculated 
    //by player current y position + spawnPozYOffset 
    public float spawnPozYOffSet = 15;

    // cooldown for when should the object spawn
    public float cooldown = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (cooldown <= 0)
        {
            cooldown = 0;
        }
        // setting up where the object will spawn
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), player.transform.position.y + spawnPozYOffSet, 0);

        debrisIndex = Random.Range(0, debrisPrefab.Length);
        if (cooldown == 0)
        {
            //spawning the object
            Instantiate(debrisPrefab[debrisIndex], spawnPos,
            debrisPrefab[debrisIndex].transform.rotation);
            cooldown = 2;
        }
        cooldown -= Time.deltaTime;
    }
}
