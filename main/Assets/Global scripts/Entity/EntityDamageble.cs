using UnityEngine;
using System;

public class EntityDamageble : MonoBehaviour
{
    public Entity @Entity;

    public void Setup(Entity entity) => @Entity = entity;

    public event Action<int> DamageAplaied;

    public void AplayDamage(int damage){
        if(damage < 0) return;

        @Entity.Health -= ProcessingDamage(damage);
        DamageAplaied?.Invoke(damage);
    }

    protected virtual int ProcessingDamage(int damage) => damage; // В будущем можно перезаписать в другом классе и чё-то делать с показателем damage
}
