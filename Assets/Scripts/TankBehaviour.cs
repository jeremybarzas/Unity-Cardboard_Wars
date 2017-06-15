using UnityEngine;

public class TankBehaviour : MonoBehaviour
{
    public static OnHealthChanged onHealthChanged = new OnHealthChanged();
    public int hp;
    public ProjectileBehaviour shellPrefab;

    public Tank tank_Attrib;
    public Animator tankDeathAnimator;
    
    public void OnTriggerEnter(Collider other)

    {
        if (!other.CompareTag("Projectile")) return;

        hp -= shellPrefab.Dmg;
        var stringtosend = string.Format("{0},{1}", name, hp);
        onHealthChanged.Invoke(stringtosend);
    }
}