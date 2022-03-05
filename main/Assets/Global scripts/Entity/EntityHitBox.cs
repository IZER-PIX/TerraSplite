using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityHitBox : MonoBehaviour, IWeaponVisitor
{
    protected Entity _entity;
    protected Collider2D _hitBox;

    private void Awake(){
        _entity = GetComponent<Entity>();
        _hitBox = GetComponent<Collider2D>();
    }

    private void DisableHitBox() => _hitBox.enabled = false;
    private void EnableHitBox() => _hitBox.enabled = true;

    public virtual void Visit(Sword weapon){
        OverlapVisit(weapon);
    }
    public virtual void Visit(Gun weapon, RaycastHit2D hit){
        RaycastVisit(weapon, hit);
    }

    protected void OverlapVisit(WeaponOverlap weapon, int damageMultiplier = 1){
        int damage = weapon.Damage * damageMultiplier;
        _entity.@EntityDamageble.AplayDamage(damage);
    }
    protected void RaycastVisit(WeaponRaycast weapon, RaycastHit2D hit, int damageMultiplier = 1){
        int damage = weapon.Damage * damageMultiplier;
        _entity.@EntityDamageble.AplayDamage(damage);
    }
}
