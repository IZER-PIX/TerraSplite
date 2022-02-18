using System;
using UnityEngine;

public  class Entity : MonoBehaviour
{
    [SerializeField] protected Attack _attack;
    [SerializeField] protected Movement _movement;

    public int Health;
    public int Damage;
    public int Level;
    public int LevelPoints;

    private Vector3 Track(GameObject gObject) => gObject.transform.position;
}
