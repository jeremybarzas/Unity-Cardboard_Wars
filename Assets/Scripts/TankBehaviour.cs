using UnityEngine;

public class TankBehaviour : MonoBehaviour
{
    public static OnHealthChanged onHealthChanged = new OnHealthChanged();
    public static OnTankDeath onTankDeath = new OnTankDeath();
    public int hp;

    public Tank tank_Attrib;
    public Animator tankDeathAnimator;

    private void Start()
    {
        hp = tank_Attrib.Health;
    }

    private void Update()
    {
        FallDeath();
    }

    private void FallDeath()
    {
        if (!(transform.position.y < -10)) return;
        hp = 0;
        onTankDeath.Invoke(name);
    }

    public void OnTriggerEnter(Collider other)
    {
        var projectile = other.gameObject.GetComponent<ProjectileBehaviour>();

        if (!other.CompareTag("Projectile")) return;
        if (!projectile.harmful) return;

        projectile.harmful = false;
        hp -= projectile.Dmg;
        var stringtosend = string.Format("{0},{1}", name, hp);
        onHealthChanged.Invoke(stringtosend);
        if (hp <= 0)
            onTankDeath.Invoke(name);
    }
}