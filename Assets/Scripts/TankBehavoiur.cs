﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class TankBehaviour : MonoBehaviour
{
    public ScriptableObject tank_Attrib;
    public static OnHealthChanged onHealthChanged;
    private TankBehaviour tankBehaviour;
    public Animator tankDeath;
	// Use this for initialization
    private int hp;

    void OnTriggerEnter(Collider other)
    {
        if (CompareTag("Player"))
        {
            hp -= GetComponent<Projectile>().Damage;
        }
    }

    void OnEnable()
    {
        hp = 100;
    }
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public class OnHealthChanged : UnityEvent<TankBehavoiur>
    {
    }
}
