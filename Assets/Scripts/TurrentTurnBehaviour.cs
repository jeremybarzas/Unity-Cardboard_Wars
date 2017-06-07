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
        // store old rotation
        var prevRot = transform.rotation;
        var prevY = prevRot.y;

        var LookAtPoint = new Vector3(target.transform.position.x, transform.position.y, target.transform.position.z);
        // make look at target and store new z
        transform.LookAt(LookAtPoint);
    }

    void OnDrawGizmos()
    {
        Gizmos.DrawLine(this.transform.position, target.transform.position);
    }
}