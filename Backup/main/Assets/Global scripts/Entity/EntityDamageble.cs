using UnityEngine;
using System;

public class EntityDamageble : MonoBehaviour
{
    public event Action<int> DamageAplaied;

    private Entity _entity;

    private void Awake(){
        _entity = GetComponentInParent<Entity>();
    }

    public void AplayDamage(int damage){
        if(damage < 0) return;

        _entity.Health = Mathf.Clamp(_entity.Health - damage, 0, _entity.MaxHealth);
        DamageAplaied?.Invoke(damage);
    }
}
