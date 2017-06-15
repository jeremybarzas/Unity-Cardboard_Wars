using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class HealthImageBehaviour : MonoBehaviour
{
    public OnHealthChanged healthChanged;
    public Sprite playerHealth;
    public List<Sprite> healthStates;

    void Awake()
    {
        healthChanged.AddListener(SetImage);
    }

    void Start()
    {
        healthStates = new List<Sprite>();
    }

    private void SetImage(TankBehaviour tank)
    {
        if (tank.hp == 100)
        {
            playerHealth = healthStates[0];
        }
    }
}
