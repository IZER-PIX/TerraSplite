using System;
using UnityEngine;

public  class Entity : MonoBehaviour
{
    [SerializeField] protected Movement _movement;

    [SerializeField] protected int _health;
    [SerializeField] protected int _level;
    [SerializeField] protected int _levelPoints;

    private EntityDamageble _entityDamageble;

    public int Health {
        get => _health;
        set {
            if(value > 0) _health = value;
        }
    }
    public int Level {
        get => _level;
        set { if(value > 0) _level = value;}
    }
    public int LevelPoints {
        get => _levelPoints;
        set { if(value > 0) _levelPoints = value;}
    }
    public EntityDamageble @EntityDamageble{
        get => @EntityDamageble;
        set{}
    }
}
