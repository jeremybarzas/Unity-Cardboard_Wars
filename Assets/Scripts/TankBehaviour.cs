using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class TankBehaviour : MonoBehaviour
{
    public Tank tank_Attrib;
    public static OnHealthChanged onHealthChanged;
    public ProjectileBehaviour shellPrefab;
    public int hp;

    void Awake()
    {
        onHealthChanged = new OnHealthChanged();
    }

    void Start()
    {
        hp = 100;
        onHealthChanged.Invoke(this);
    }

    void OnEnable()
    {
        hp = 100;
        onHealthChanged.Invoke(this);
    }

    void OnTriggerEnter(Collider other)
    {
        if (CompareTag("Player"))
        {
            hp -= shellPrefab.Dmg;
            onHealthChanged.Invoke(this);
            Destroy(shellPrefab);
            Debug.Log(hp);
        }
    }

	void Update ()
    {
        
	}
}
