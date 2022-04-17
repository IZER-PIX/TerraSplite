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
        float distance = Vector2.Distance(transform.position, TrackedObject.position);

        Vector2 direction = TrackedObject.position - transform.position;

        RaycastHit2D hit = Physics2D.Raycast(transform.position, direction.normalized * ViewDistance);
        Debug.DrawRay(transform.position, direction.normalized * ViewDistance, Color.red);
        
        var collider = hit.collider;
        if(hit.collider.name == "PlayerBody")
        {
            Debug.Log("Yes");
        }
    }
}
