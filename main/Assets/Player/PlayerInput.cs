using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    private PlayerActions _input;
    private Player _player;
    
    private void OnEnable()  => _input.Enable();
    private void OnDisable() => _input.Disable();

    private void Awake() {
        _input = new PlayerActions();
        _input.Actions.Attack.performed += ctx => Attack();

        _player = GetComponent<Player>();
    }

    private void Update() {
        Vector2 direction = _input.Move.WASD.ReadValue<Vector2>();
        _player._movement.Move(direction);

        if(_input.Actions.Shift.triggered){
            _player._movement.Shift(direction);
        }
    }
}
