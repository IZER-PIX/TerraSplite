using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public abstract class WeaponRaycast : Weapon
{
    // protected event Action<RaycastHit2D> HitIsNotDesiredTarget;
    protected event Action<RaycastHit2D> HitIsDesiredTarget;

    protected virtual void Attack(){
        var mouse = 
            Utils.Vector3To2(Camera.main.ScreenToWorldPoint
                (Mouse.current.position.ReadValue())).normalized;

        Vector2 direction = mouse - Utils.Vector3To2(transform.position);

        LayerMask enemyMask = LayerMask.GetMask("Enemy");

        RaycastHit2D hit = Physics2D.Raycast(transform.position, direction.normalized, 50f, enemyMask);

        if(hit){
            Debug.Log("Hit: " + hit.collider.name);
            ScanHit(hit);
        }
    }
    private void ScanHit(RaycastHit2D hit){
        var collider = hit.collider.gameObject;

        if(!collider.TryGetComponent(out IWeaponVisitor visitor)) return;

        Accept(visitor, hit);
        HitIsDesiredTarget?.Invoke(hit);
    }

    protected abstract void Accept(IWeaponVisitor visitor, RaycastHit2D hit);

    private void OnDrawGizmos(){
        Gizmos.color = Color.red;

        Gizmos.DrawRay(transform.position,
            Utils.Vector3To2(Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue()))- 
            Utils.Vector3To2(transform.position));
    }
}