using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehaviour : MonoBehaviour
{
    public ScriptableObject ProjectileScriptableObject;
    private int Dmg;
    private GameObject shell;
    void OnTriggerEnter(Collider other)
    {
        if (CompareTag("Player"))
        {
            Destroy(shell);
        }
    }
	// Use this for initialization
	void Start ()
	{
	    Dmg = GetComponent<Projectile>().Damage;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
