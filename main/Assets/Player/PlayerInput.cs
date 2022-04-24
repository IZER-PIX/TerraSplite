using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private GameObject _stats;

    private Sword _sword;
    private PlayerActions _input;
    private Player _player;
    private Gun _gun;
    
    private void OnEnable()  => _input.Enable();
    private void OnDisable() => _input.Disable();

    private void Awake() {
        _input = new PlayerActions();

        _player = GetComponent<Player>();
        _gun = GetComponentInChildren<Gun>();
        _sword = GetComponentInChildren<Sword>();

        _input = new PlayerActions();
        _input.Actions.RaycastAttack.performed += ctx => _gun.Attack();
        _input.Actions.OverlapAttack.performed += ctx => _sword.Attack();
        _input.Actions.Reload.performed += ctx => _gun.Reaload(15);
        _input.Actions.ShowPlayerStats.performed += ctx => StatsActive();
    }

    private void FixedUpdate() {
        Vector2 direction = GetInputDirection();
        _player.Move(direction);
    }

    public Vector2 GetInputDirection() => _input.Move.WASD.ReadValue<Vector2>();

    private void StatsActive()
    {
        if(_stats.activeSelf)
        {
            _stats.SetActive(false);
            return;
        }
        if(!_stats.activeSelf)
        {
            _stats.SetActive(true);
            return;
        }
    }
}