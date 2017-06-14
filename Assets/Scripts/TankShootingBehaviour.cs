using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankShootingBehaviour : MonoBehaviour
{
    public GameObject TankShell;
    public Transform ShellSpawn;
    private Vector3 direction;
    public Rigidbody rb;
    public AudioSource ShootingAudioSource;
    public float shootForce = 1.0f;
    /*afterthoughts go down here v
    private Random shootCone;
    */
    void Fire()
    {
        Instantiate(TankShell);
    }
	// Use this for initialization
    void Start()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
            Fire();
    }
	
	// Update is called once per frame
	void Update ()
	{
	    direction.z += shootForce;
	}
}
