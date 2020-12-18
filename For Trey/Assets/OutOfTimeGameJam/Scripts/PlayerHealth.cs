using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    //health
    public static int health = 100;
    public Slider healthBar;
    //to know when to end the game
    public static bool gameOver;

    public GameObject gameOverPanel;

    // Start is called before the first frame update
    void Start()
    {
        //when game starts 'gameOver' set to false
        gameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        //update health bar value
        healthBar.value = health;
        //game over when players health reaches zero
        if(health < 0)
        {
            //set to true
            gameOver = true;
            gameOverPanel.SetActive(true);
            health = 100;
        }
    }


}
