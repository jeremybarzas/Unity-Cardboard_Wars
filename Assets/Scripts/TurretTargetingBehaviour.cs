using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretTargetingBehaviour : MonoBehaviour
{
    public GameObject target;
    public GameObject turret;
    public GameObject cannon;

    void TraverseTurret(GameObject target)
    {
        // store new rotation with Quaternion.LookRotation Method.
        var targetRotation = Quaternion.LookRotation(target.transform.position - transform.position);

        // lock turret x and z axis in place
        targetRotation.x = transform.rotation.x;
        targetRotation.z = transform.rotation.z;

        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 3 * Time.deltaTime);
    }

    void PitchCannon(GameObject target)
    {
        // store new rotation with Quaternion.LookRotation Method.
        var targetPositon = target.transform.position;
        var targetRotation = Quaternion.LookRotation(targetPositon - transform.position);

        targetRotation.y = transform.rotation.y;

        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 3 * Time.deltaTime);
    }

    void RotateToTarget(GameObject target)
    {
        TraverseTurret(target);
        PitchCannon(target);
    }

    private void Start()
    {

    }

    private void Update()
    {
    }


}
