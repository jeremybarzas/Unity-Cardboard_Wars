using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class TankBehaviour : MonoBehaviour
{
    public Tank tank_Attrib;
    public static OnHealthChanged onHealthChanged = new OnHealthChanged();
    public ProjectileBehaviour shellPrefab;
    public int hp;
 
    public void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Projectile")) return;

        hp -= shellPrefab.Dmg;
        var stringtosend = string.Format("{0},{1}", name, hp);
        onHealthChanged.Invoke(stringtosend);
    }
}
