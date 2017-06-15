using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class TankBehavoiur : MonoBehaviour
{
    public Tank tank;
    public OnHealthChanged onHealthChanged;
    public Animator tankDeath;
	// Use this for initialization
    private int hp;

    void OnTriggerEnter(Collider other)
    {
        if (CompareTag("Player"))
        {
            hp -= GetComponent<Projectile>().Damage;
        }
    }

    void Awake()
    {
        onHealthChanged = new OnHealthChanged();
    }
    void OnEnable()
    {
        hp = 100;
    }
    void Start () {
		onHealthChanged.Invoke(this);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public class OnHealthChanged : UnityEvent<TankBehavoiur>
    {
    
    }
}
