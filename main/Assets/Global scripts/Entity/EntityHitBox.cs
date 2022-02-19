using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityHitBox : Entity, IWeaponVisitor
{
    [SerializeField] protected Entity _entity;
    [SerializeField] protected Collider2D _hitBox;


    private void DisableHitBox() => _hitBox.enabled = false;
    private void EnableHitBox() => _hitBox.enabled = true;

    public void Visitor(Sword weapon){
        OverlapVisit(weapon);
    }
    public void Visitor(Gun weapon, RaycastHit hit){
        RaycastVisit(weapon, hit);
    }
    public void Visitor(MagicBall weapon, RaycastHit hit){
        RaycastVisit(weapon, hit);
    }

    protected void OverlapVisit(Weapon weapon, int damageMultiplier = 1){
        int damage = weapon.Damage * damageMultiplier;
        _entity.@EntityDamageble.AplayDamage(damage);
    }
    protected void RaycastVisit(Weapon weapon, RaycastHit hit, int damageMultiplier = 1){
        int damage = weapon.Damage * damageMultiplier;
        _entity.@EntityDamageble.AplayDamage(damage);
    }
}
