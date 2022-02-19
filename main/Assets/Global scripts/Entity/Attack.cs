using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    [SerializeField] private int Damage;
    [SerializeField] private GameObject Weapon;
    
    private GameObject _target, _damager;

    private void OnCollisionEnter2D(Collision2D target){
        
    }
}
