using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyPositionBehaviour : MonoBehaviour
{
    public Transform tank;

    void Update()
    {
        transform.position = tank.position;
    }
}
