using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Text gameOver;
    private Health player;
    public bool alive;

   
    void Start()
    {
        alive = true;
        player = GetComponent<Health>();
        gameOver.GetComponent<Text>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(player.currentHealth <= 0)
        {
            alive = false;
        }
        if(alive == false)
        {
            gameOver.GetComponent<Text>().enabled = true;
            
        }
    }
}
