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
        var targetPositon = target.transform.position;
        var targetRotation = Quaternion.LookRotation(targetPositon - transform.position);
        
        // lock cannon y and z axis in place
        //targetRotation.y = transform.rotation.y;
        //targetRotation.z = transform.rotation.z;

        // set rotation of the object 
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 5 * Time.deltaTime);        
    }

    void OnDrawGizmos()
    {
        Gizmos.DrawLine(this.transform.position, target.transform.position);
    }
}