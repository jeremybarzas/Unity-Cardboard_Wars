using UnityEngine;

public class TankBehaviour : MonoBehaviour
{
    public static OnHealthChanged onHealthChanged = new OnHealthChanged();
    public int hp;

    public Tank tank_Attrib;
    public Animator tankDeathAnimator;
    
    public void OnTriggerEnter(Collider other)
    {
        var projectile = other.gameObject.GetComponent<ProjectileBehaviour>();
        
        if (!other.CompareTag("Projectile")) return;
        if (!projectile.harmful) return;

        projectile.harmful = false;
        hp -= projectile.Dmg;
        var stringtosend = string.Format("{0},{1}", name, hp);
        onHealthChanged.Invoke(stringtosend);
    }
}