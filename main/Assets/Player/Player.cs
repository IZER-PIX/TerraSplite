using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : Entity
{
    private PlayerActions _input;

    #region singleton
    private static Player instance = null;
    public static Player singleton {
        get {
            if(instance == null) instance = new Player();
            return instance;
        }
    }
    #endregion
    
    private void OnEnable()  => _input.Enable();
    private void OnDisable() => _input.Disable();
    private void OnDestroy() => _input.Disable();

    private void Awake() {
        _input = new PlayerActions();
    }

    private void Update() {
        Vector2 direction = _input.Move.WASD.ReadValue<Vector2>();
        _movement.Move(direction);

        if(_input.Actions.Shift.triggered){
            _movement.Shift(direction);
        }
    }

    public void TEST(){
        PlayerEventManager.OnLevelIncerasing(2);
        Debug.Log("TEST");
    }
}