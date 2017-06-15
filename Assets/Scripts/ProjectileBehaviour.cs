using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehaviour : MonoBehaviour
{
    public Projectile projectileConfig;
    public int Dmg;
    public GameObject shell;
    void OnTriggerEnter(Collider other)
    {
        if (CompareTag("Player"))
        {
            DestroyImmediate(this, true);
        }
    }
	// Use this for initialization
	void Start ()
	{
	    Dmg = projectileConfig.Damage;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
