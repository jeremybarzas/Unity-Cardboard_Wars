using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyRotationBehaviour : MonoBehaviour
{
    public Transform cannonCollider;
	
	void Update ()
    {
        transform.rotation = cannonCollider.transform.rotation;
	}
}
