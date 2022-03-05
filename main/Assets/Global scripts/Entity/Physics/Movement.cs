using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float Speed;
    private Rigidbody2D _rigidbody;

    private void Awake() {
        _rigidbody = GetComponent<Rigidbody2D>();
        _rigidbody.gravityScale = 0f;
    }
    public void Move(Vector2 direction){
        Vector2 offset = direction * Speed * Time.fixedDeltaTime;
        _rigidbody.MovePosition(_rigidbody.position + offset);
    }

    public void Shift(Vector2 direction){
        Vector2 shiftOffset = direction * Speed * 2 * Time.fixedDeltaTime;
        _rigidbody.MovePosition(_rigidbody.position + shiftOffset);
    }
}