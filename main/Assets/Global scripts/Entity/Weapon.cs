using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private int _damage;

    public int Damage {
    	get => _damage;
    	set { if(value > 0) _damage = value; }
    }
}
