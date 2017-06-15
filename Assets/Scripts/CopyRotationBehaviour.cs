using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyRotationBehaviour : MonoBehaviour
{
    public Transform cannonCollider;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.rotation = cannonCollider.transform.rotation;
	}

    void LateUpdate()
    {

    }
}
