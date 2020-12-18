using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{


    void Start()
    {
        //Set the tag of this GameObject to Player
        gameObject.tag = "Player";
    }

    //OnTriggerEnter - if you want gameObject to go through the player
    //OnCollisionEnter - if you want gameObject to bump into player
    private void OnTriggerEnter(Collider collider)
    {
        int damage = 20;
        //if game object has "damage" tag
        if (collider.gameObject.tag == "Player")
        {
            Debug.Log("player touched damageCube");
            PlayerHealth.health -= damage;
        }
    }

}
