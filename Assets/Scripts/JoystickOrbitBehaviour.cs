using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickOrbitBehaviour : MonoBehaviour
{
    public Transform tank;
    public Transform target;

    private bool zoomed;

    public float distance = 5.0f;
    public float yMinLimit = -20f;
    public float yMaxLimit = 80f;
    public float xMinLimit = -20f;
    public float xMaxLimit = 80f;

    private Rigidbody rigidbody;

    float x = 0.0f;
    float y = 0.0f;

    void Start()
    {
        Vector3 angles = transform.eulerAngles;
        x = angles.y;
        y = angles.x;

        rigidbody = GetComponent<Rigidbody>();

        // Make the rigid body not change rotation
        if (rigidbody != null)
        {
            rigidbody.freezeRotation = true;
        }
    }

    void Update()
    {
        if (Input.GetButtonDown("ZoomInController"))
        {
            if (!zoomed)
            {
                zoomed = true;
                distance = -10f;
            }
            else
            {
                zoomed = false;
                distance = 7;
            }
        }

        xMaxLimit = tank.rotation.eulerAngles.y + 20f;
        xMinLimit = tank.rotation.eulerAngles.y - 20f;

        if (target)
        {
            x += Input.GetAxis("TankxController");
            y -= Input.GetAxis("TankyController");

            x = ClampAngle(x, xMinLimit, xMaxLimit);
            y = ClampAngle(y, yMinLimit, yMaxLimit);

            Quaternion rotation = Quaternion.Euler(y, x, 0);

            Vector3 negDistance = new Vector3(0.0f, 0.0f, -distance);
            Vector3 position = rotation * negDistance + target.position;

            transform.rotation = rotation;
            transform.position = position;
        }
    }

    public static float ClampAngle(float angle, float min, float max)
    {
        if (angle < -360F)
            angle += 360F;
        if (angle > 360F)
            angle -= 360F;
        return Mathf.Clamp(angle, min, max);
    }
}
