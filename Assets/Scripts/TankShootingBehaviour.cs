using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankShootingBehaviour : MonoBehaviour
{
    public GameObject TankShell;
    private GameObject TankShell_RunTime;
    public Transform ShellSpawn;
    private Vector3 direction;
    public AudioSource ShootingAudioSource;
    private float shootForce = 20.0f;
    private Vector3 shootDistance;
    /*afterthoughts go down here v
    private Random shootCone;
    */
    void Fire()
    {
        direction = ShellSpawn.transform.forward; 
        TankShell_RunTime = Instantiate(TankShell, ShellSpawn.position, ShellSpawn.rotation);
        Rigidbody shellRB = TankShell_RunTime.GetComponent<Rigidbody>();
        shellRB.AddForce(direction * shootForce, ForceMode.Impulse);
    }
	// Use this for initialization
    void Start()
    {
    }
	
	// Update is called once per frame
	void Update ()
	{        
	    if (Input.GetButtonDown("Fire1"))
	    {
	        Fire();
	    }
    }
}
