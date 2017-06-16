using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehaviour : MonoBehaviour
{
    public Projectile projectileConfig;
    public bool harmful = true;
    public int Dmg;

    // Use this for initialization
    void Start()
    {
        Dmg = projectileConfig.Damage;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Level")) return;
        if (!this.harmful) return;
        harmful = false;
    }
}
