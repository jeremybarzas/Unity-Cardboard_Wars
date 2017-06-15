using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class TankBehaviour : MonoBehaviour
{
    public Tank tank_Attrib;
    public OnHealthChanged onHealthChanged = new OnHealthChanged();
    public ProjectileBehaviour shellPrefab;
    public int hp;

    void OnTriggerEnter(Collider other)
    {
        if (CompareTag("Player"))
        {
            hp -= shellPrefab.Dmg;
            onHealthChanged.Invoke(hp);
            Debug.Log(hp);
        }
    }
}
