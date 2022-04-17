using System;
using UnityEngine;

public abstract class WeaponOverlap : Weapon
{
    public event Action<Collider2D> HitIsDesiredTarget;

    [SerializeField] protected float AttackRange;
    [SerializeField] private LayerMask Layers;

    public virtual void Attack()
    {
        Collider2D[] hit = Physics2D.OverlapCircleAll(transform.position, AttackRange, Layers);

        foreach(var item in hit)
            ScanHit(item);
    }

    private void ScanHit(Collider2D hit){
        var collider = hit.collider.gameObject;

        if(!collider.TryGetComponent(out IWeaponVisitor visitor)) return;

        Accept(visitor);
        HitIsDesiredTarget?.Invoke(hit);
    }

    public abstract void Accept(IWeaponVisitor visitor);

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, AttackRange);
    }
}
