using System;
using UnityEngine;

public  class Entity : MonoBehaviour
{   
    private EntityDestroy _entityDestroy;

    protected Movement _movement;

    [SerializeField] protected int _maxHealth = 20;
    [SerializeField] protected int _health;
    [SerializeField] protected int _level;
    [SerializeField] protected int _levelPoints;

    public EntityDamageble @EntityDamageble;

    public int Health {
        get => _health;
        set {
            if(value >= 0 || value < _maxHealth) _health = value;
        }
    }
    public int MaxHealth {
        get => _maxHealth;
        set {if(value > 0) _maxHealth = value;}
    }
    public int Level {
        get => _level;
        set { if(value > 0) _level = value;}
    }
    public int LevelPoints {
        get => _levelPoints;
        set { if(value > 0) _levelPoints = value;}
    }

    private void Awake(){
        _entityDestroy = GetComponent<EntityDestroy>();
    }
    private void Update(){
        if(Health <= 0) _entityDestroy.OnDestroyEntity();
    }
}
