using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class TankBehaviour : MonoBehaviour
{

    public static OnHealthChanged onHealthChanged;
    public ProjectileBehaviour shellPrefab;
    public int hp;
    public Animator tankDeathAnimator;
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
        if (other.CompareTag("Projectile"))
        {
            if (hp > 10)
            {
                hp -= shellPrefab.Dmg;
                Destroy(other.gameObject);
                onHealthChanged.Invoke(this);
            }
            else if (hp == 10)
            {
                hp -= shellPrefab.Dmg;
                //tank death animator goes here
            }
            Debug.Log(hp);
        }
        
    }

	void Update ()
    {
        
	}
}
