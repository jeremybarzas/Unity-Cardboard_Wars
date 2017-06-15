using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Animator), typeof(Rigidbody))]
public class TankAnimationBehaviour : MonoBehaviour
{
    private Animator animator;
    private Rigidbody rb;
    private readonly int speed = Animator.StringToHash("speed");
	// Use this for initialization
	void Start ()
	{
	    animator = GetComponent<Animator>();
	    rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		animator.SetFloat(speed, rb.velocity.magnitude);
	}
}
