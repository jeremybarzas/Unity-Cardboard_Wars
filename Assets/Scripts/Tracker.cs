using UnityEngine;
using System.Collections;

public class Tracker : MonoBehaviour
{
    public Transform tank;
    public Transform target;
    public float maxAngle = 35.0f;
    private Quaternion baseRotation;
    private Quaternion targetRotation;

    void Update()
    {
        baseRotation = tank.rotation;

        Vector3 look = target.transform.position - transform.position;

        Quaternion q = Quaternion.LookRotation(look);
        if (Quaternion.Angle(q, baseRotation) <= maxAngle)
            targetRotation = q;

        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * 3f);
    }
}