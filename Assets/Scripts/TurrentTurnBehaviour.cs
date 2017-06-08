using UnityEngine;

public class TurrentTurnBehaviour : MonoBehaviour
{
    public GameObject target;

    private void Update()
    {
        TraverseTurret(target);
    }

    void TraverseTurret(GameObject target)
    {
        // store new rotation with Quaternion.LookRotation Method.
        var targetRotation = Quaternion.LookRotation(target.transform.position - transform.position);

        // lock turret x and z axis in place
        targetRotation.x = transform.rotation.x;
        targetRotation.z = transform.rotation.z;

        // set rotation of the object
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 2 * Time.deltaTime);
    }

    void OnDrawGizmos()
    {
        Gizmos.DrawLine(this.transform.position, target.transform.position);
    }
}