using UnityEngine;

public class TankMoveBehaviour : MonoBehaviour
{
    private void CharacterMove()
    {
        var speed = 15.0f;
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);
    }

    private void Update()
    {
        CharacterMove();
    }
}