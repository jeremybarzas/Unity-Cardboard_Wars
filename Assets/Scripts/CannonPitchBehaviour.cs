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
        var targetRotation = Quaternion.LookRotation(target.transform.position - transform.position);
        this.transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 5 * Time.deltaTime);

        //var LookAtPoint = new Vector3(target.transform.position.x, target.transform.position.y, target.transform.position.z);
        //transform.LookAt(LookAtPoint);
    }

    void OnDrawGizmos()
    {
        Gizmos.DrawLine(this.transform.position, target.transform.position);
    }
}