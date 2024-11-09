using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    public String playerName;
    public int health;
    static public int playerCount = 0;


    public void InitializePlayer(string name, int initialHealth)
    {
        playerName = name;
        health = initialHealth;
        playerCount++;
    }

    public void Heal(int amount)
    {
        health += amount;
        Debug.Log("Updated health: " + health);
    }

    public void Heal(bool fullRestore)
    {
        if (fullRestore)
        {
            health = 100;
        }
    }

    public void ShowPlayerCount()
    {
        Debug.Log("Number of player: " + playerCount);
    }


}
