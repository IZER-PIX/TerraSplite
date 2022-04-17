using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private SpriteRenderer _sprite;
    
    private PlayerInput _player;
    private PlayerActions _input;

    private void OnEnable()  => _input.Enable();
    private void OnDisable() => _input.Disable();

    private void Awake()
    {
        _input = new PlayerActions();
        _player = GetComponentInParent<PlayerInput>();
        _animator = GetComponent<Animator>();

        _input.Actions.OverlapAttack.performed += ctx => _animator.SetTrigger("Attack");
    }

    private void Update()
    {
        var speed = _player.GetInputDirection().magnitude;
        _animator.SetFloat("Speed", speed);
    }
}
