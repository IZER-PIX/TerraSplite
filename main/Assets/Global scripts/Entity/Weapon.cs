using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField]private Entity _weaponOwner;
    [SerializeField]private int _damage;
    [SerializeField]private int _ammunition;

    protected bool allowShooting = true;

    public Entity WeaponOwner{
        get => _weaponOwner;
        set { if(value != null) _weaponOwner = value; }
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
        get => allowShooting;
        set => allowShooting = value;
    }

    public void SpendAmmo(int amount){
        _ammunition -= amount;
        if(_ammunition <= 0) allowShooting = false;
    }
    public void Reaload(int amount){
        _ammunition += amount;
        allowShooting = true;
    }
}
