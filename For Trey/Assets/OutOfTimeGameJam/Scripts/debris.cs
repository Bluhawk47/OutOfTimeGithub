using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class debris : MonoBehaviour
{
    private AudioSource playerAudio;
    public AudioClip deathSound;
    // attach player prefab
    public GameObject player;
    //offset of what y position where the object will be destroy, Y destroy position will be calculated 
    //by player current y position + destroyOffset 
    public float destroyOffset = -10;
    // Start is called before the first frame update
    void Start()
    {
        playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // setting up the position where debris will be desytroy 
        if (transform.position.y <= player.transform.position.y + destroyOffset)
        {

            Destroy(gameObject);
        }
    }
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playerAudio.PlayOneShot(deathSound, 1.0f);

        }
        if(other.gameObject.CompareTag("Ground"))
        {
            Destroy(gameObject);
        }
    }
}
