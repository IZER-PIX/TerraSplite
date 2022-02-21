using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    private Entity _weaponOwner;
    private int _damage;
    private int _ammunition;

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
