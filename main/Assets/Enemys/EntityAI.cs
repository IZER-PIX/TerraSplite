using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityAI : MonoBehaviour
{
    [SerializeField] private Transform TrackedObject;
    [SerializeField] private float ViewDistance = 5f;

    private Entity _entity;
    private Rigidbody2D _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _entity = GetComponentInParent<Entity>();
    }

    private void Update()
    {
    }
}
