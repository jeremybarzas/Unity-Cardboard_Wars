using UnityEngine;

public class CannonPitchBehaviour : MonoBehaviour
{
    public GameObject target;

    private void Update()
    {
        transform.LookAt(target.transform);
    }

    void PitchCannon(GameObject target)
    {
        // store old rotation
        var prevRot = transform.rotation;
        var prevX = prevRot.x;
        var prevY = prevRot.y;

        var LookAtPoint = new Vector3(target.transform.position.x, transform.position.y, target.transform.position.z);
        // make look at target and storee new z
        transform.LookAt(LookAtPoint);
        var newZ = transform.rotation.z;

        // set new rotations x and y to the previous x and y to keep them "locked"
        Vector3 newRot = new Vector3(prevX, 0, prevX);
        transform.Rotate(newRot);

    }

    void OnDrawGizmos()
    {
        Gizmos.DrawLine(this.transform.position, target.transform.position);
    }
}