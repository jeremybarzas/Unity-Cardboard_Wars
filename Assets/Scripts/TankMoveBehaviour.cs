using UnityEngine;

public class TankMoveBehaviour : MonoBehaviour
{
    public float speed = 5;

    private void CharacterMove()
    {
        var y = Input.GetAxis("Horizontal") * Time.deltaTime * speed * 25;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        transform.Rotate(0, y, 0);
        transform.Translate(0, 0, z);
    }

    private void Update()
    {
        CharacterMove();
    }
}