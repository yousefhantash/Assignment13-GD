using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Player playerOne = new Player();
        Player playerTwo = new Player();

        playerOne.InitializePlayer("yousef", 90);
        playerTwo.InitializePlayer("ahmad", 80);

        playerTwo.Heal(10);
        playerTwo.Heal(true);

        playerOne.ShowPlayerCount();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
