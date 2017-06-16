using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverBehaviour : MonoBehaviour
{
    private TankBehaviour player;

    private void Awake()
    {
        TankBehaviour.onTankDeath.AddListener(SetText);
    }

    public void SetText(string name)
    {
        var p1 = "P l a y e r 1" + " sucks at this game.";
        var p2 = "P l a y e r 2" + " sucks at this game.";
        if (name == "Player1")
            GetComponent<Text>().text = p1;
        if (name == "Player2")
            GetComponent<Text>().text = p2;
    }
}
