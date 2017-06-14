using UnityEngine;

public class CannonPitchBehaviour : MonoBehaviour
{
    public GameObject target;

    private void Update()
    {
        PitchCannon(target);
    }

    void PitchCannon(GameObject target)
    {
        // store new rotation with Quaternion.LookRotation Method.
        var targetRotation = Quaternion.LookRotation(target.transform.position - transform.position);

        // lock turret x and z axis in place
        //targetRotation.y = transform.localRotation.y;
        //targetRotation.z = transform.localRotation.z;

        // set rotation of the object
        transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation, 4 * Time.deltaTime);
    }

    void OnDrawGizmos()
    {
        Gizmos.DrawLine(this.transform.position, target.transform.position);
    }
}