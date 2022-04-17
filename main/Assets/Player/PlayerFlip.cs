using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerFlip : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _sprite;
    [SerializeField] private Transform _sword;

    private PlayerInput _playerDirection;

    private void Awake()
    {
        _playerDirection = GetComponentInParent<PlayerInput>();
    }

    private void Update()
    {
        var horizontal = _playerDirection.GetInputDirection().x;

        if(horizontal > 0f)
        {
            var newScale = new Vector3(1f, 1f, 1f);
            transform.localScale = newScale;
        }
        if(horizontal < 0f)
        {
            var newScale = new Vector3(-1f, 1f, 1f);
            transform.localScale = newScale;
        }
    }

    // private void Flip() 
    // {
    //     var newScale = new Vector3(-1f, 0f, 0f);
    //     transform.localScale = newScale;
    // }
}