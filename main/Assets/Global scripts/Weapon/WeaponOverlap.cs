using System;
using UnityEngine;

public abstract class WeaponOverlap : Weapon
{
    public event Action<Collider2D> OnVisit;

    public Transform SwordPosition;

    [SerializeField] protected float AttackRange;
    [SerializeField] private LayerMask Layers;

    private void Awake()
    {
        SwordPosition = transform;
    }

    public virtual void Attack()
    {
        Collider2D[] hit = Physics2D.OverlapCircleAll(SwordPosition.position, AttackRange, Layers);

        for(int i = 0; i < hit.Length; i++)
        {
            var target = hit[i].gameObject;

            Debug.Log(target);

            if(!target.TryGetComponent(out IWeaponVisitor visitor)) continue;

            Accept(visitor);
            OnVisit?.Invoke(hit[i]);
        }
    }

    public abstract void Accept(IWeaponVisitor visitor);

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(SwordPosition.position, AttackRange);
    }
}
