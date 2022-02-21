using System;
using UnityEngine;
using UnityEngine.InputSystem;

public abstract class WeaponRaycast : Weapon
{
    private event Action<RaycastHit> HitIsNotDesiredTarget;
    private event Action<RaycastHit> HitIsDesiredTarget;

    private PlayerActions _input;

    private void OnEnable()  => _input.Enable();
    private void OnDisable() => _input.Disable();
    private void OnDestroy() => _input.Disable();

    private void Awake() {
        _input = new PlayerActions();

        _input.Actions.Attack.performed += ctx => Attack();
    }

    protected virtual void Attack(){
        Vector2 direction = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        RaycastHit hit;

        Debug.Log("Shoot");

        if(Physics.Raycast(
            WeaponOwner.transform.position, direction, out hit)){
            ScanHit(hit);
        }
    }
    private void ScanHit(RaycastHit hit){
        var collider = hit.collider.gameObject;

        if(collider.TryGetComponent(out IWeaponVisitor visitor)){
            Accept(visitor, hit);
            HitIsDesiredTarget.Invoke(hit);
        }else{
            HitIsNotDesiredTarget?.Invoke(hit);
        }
    }

    protected abstract void Accept(IWeaponVisitor visitor, RaycastHit hit);

    private void OnDrawGizmos(){
        Gizmos.color = Color.red;
        Vector2 dir = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        Gizmos.DrawRay(transform.position, (new Vector2(dir.x, -dir.y).normalized) * 10);
    }
}
