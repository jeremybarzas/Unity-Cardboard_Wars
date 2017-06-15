using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class HealthImageBehaviour : MonoBehaviour
{
    //public static OnHealthChanged onHealthChanged =  new OnHealthChanged();
    public TankBehaviour player;
    public Sprite playerHealth;
    public List<Sprite> healthStates;

    void Awake()
    {
        player.onHealthChanged.AddListener(SetImage);
    }

    void Start()
    {
        //healthStates = new List<Sprite>();
    }

    public void SetImage(int hp)
    {
        Debug.Log("SetImage Called");

        if (hp == 100)
        {
            playerHealth = healthStates[0];
        }
        if (hp == 90)
        {
            playerHealth = healthStates[1];
        }
        if (hp == 80)
        {
            playerHealth = healthStates[2];
        }
        if (hp == 70)
        {
            playerHealth = healthStates[3];
        }
        if (hp == 60)
        {
            playerHealth = healthStates[4];
        }
        if (hp == 50)
        {
            playerHealth = healthStates[5];
        }
        if (hp == 40)
        {
            playerHealth = healthStates[6];
        }
        if (hp == 30)
        {
            playerHealth = healthStates[7];
        }
        if (hp == 20)
        {
            playerHealth = healthStates[8];
        }
        if (hp == 10)
        {
            playerHealth = healthStates[9];
        }
        if (hp == 0)
        {
            playerHealth = healthStates[10];
        }
        GetComponent<Image>().overrideSprite = playerHealth;
    }
}
