using System;
using UnityEngine;
using UnityEngine.InputSystem;

public abstract class WeaponRaycast : Weapon
{
    public event Action<ContactPoint2D> HitIsDesiredTarget;
    
    public Shooting _shoot;

    public virtual void Attack(){
        var mouse = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        Vector2 direction = Utils.Vector3To2(mouse) - Utils.Vector3To2(transform.position);

        var bullet = _shoot.Shoot();

        if(bullet.Contact){
            Debug.Log(bullet.ContactedObject.collider.name);
            ScanHit(bullet.ContactedObject);
        }
    }
    private void ScanHit(ContactPoint2D hit){
        if(!hit.collider.gameObject.TryGetComponent(out IWeaponVisitor visitor)) return;

        Accept(visitor, hit);
        HitIsDesiredTarget?.Invoke(hit);
    }

    protected abstract void Accept(IWeaponVisitor visitor, ContactPoint2D hit);
}