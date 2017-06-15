using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankShootingBehaviour : MonoBehaviour
{
    public GameObject TankShell;
    private GameObject TankShell_RunTime;
    public Transform ShellSpawn;
    private Vector3 direction;    
    private float shootForce = 20.0f;
    private Vector3 shootDistance;
    public float fireRate = 0.5f;
    private float nextFire;
    public AudioSource ShootingAudioSource;
    public AudioClip shot1;
    public AudioClip shot2;
    public AudioClip shot3;
    public List<AudioClip> shotSounds;
    /*afterthoughts go down here v
    private Random shootCone;
    */
    void Fire()
    {
        direction = ShellSpawn.transform.forward; 
        TankShell_RunTime = Instantiate(TankShell, ShellSpawn.position, ShellSpawn.rotation);
        Rigidbody shellRB = TankShell_RunTime.GetComponent<Rigidbody>();
        shellRB.AddForce(direction * shootForce, ForceMode.Impulse);
        var c = Random.Range(0, 2);
        ShootingAudioSource.clip = shotSounds[c];
        ShootingAudioSource.Play();
    }
	// Use this for initialization
    void Start()
    {
        shotSounds = new List<AudioClip>();
        shotSounds.Add(shot1);
        shotSounds.Add(shot2);
        shotSounds.Add(shot3);
    }
	
	// Update is called once per frame
	void Update ()
	{        
	    if (Input.GetButtonDown("Fire1") && Time.time > nextFire)
	    {
	        nextFire = Time.time + fireRate;
	        Fire();
	    }
    }
}
