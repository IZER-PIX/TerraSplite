using System;
using System.Collections.Generic;
using UnityEngine;

public class EntityDestroy : MonoBehaviour
{
    public event Action EntityIsDestroed;

    private Entity @Entity;
    
    public void OnDestroyEntity() => EntityIsDestroed?.Invoke();

    private void Awake(){
        @Entity = GetComponentInParent<Entity>();
        EntityIsDestroed += DestroyEntity;
    }
    private void DestroyEntity() {
        Destroy(@Entity.gameObject);
    }
}
