using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    private Entity _weaponOwner;
    
    [SerializeField] private int _damage;
    [SerializeField] private int _ammunition;

    [SerializeField] protected float AttackTimeDelay = 0.5f;

    protected bool _allowShooting = true;

    private void Awake(){
        _weaponOwner = GetComponent<Entity>();
    }

    public Entity WeaponOwner{
        get => _weaponOwner;
        // set { if(value != null) _weaponOwner = value; }
    }
    public int Damage {
    	get => _damage;
    	set { if(value > 0) _damage = value; }
    }
    public int Ammo {
        get => _ammunition;
        set { if(value > 0) _ammunition = value; }
    }
    public bool AllowShooting {
        get => _allowShooting;
        set => _allowShooting = value;
    }

    public void SpendAmmo(int amount){
        _ammunition -= amount;
        if(_ammunition <= 0) _allowShooting = false;
    }
    public void Reaload(int amount){
        _ammunition += amount;
        _allowShooting = true;
    }

    protected abstract IEnumerator AttackDelay(float delay);
}
