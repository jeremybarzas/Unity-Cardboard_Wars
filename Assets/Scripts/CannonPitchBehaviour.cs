using UnityEngine;

public class CannonPitchBehaviour : MonoBehaviour
{
    public GameObject target;

    private void Update()
    {
        transform.LookAt(target.transform);
    }
}