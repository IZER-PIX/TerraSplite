using System;
using UnityEngine;

public class UpStares : MonoBehaviour
{
    public event Action OnUpStares;
    public event Action OnDownStares;    

    [SerializeField] private Camera _camera;
    [SerializeField] private float _ortSize;
    [SerializeField] private float _velocity = 0f;
    [SerializeField] private float _smoothTime = 0.3f;
    [SerializeField] private bool _onUp = false;
    
    private float _oldOrtSize;

    private void Awake()
    {
        _oldOrtSize = _camera.orthographicSize;
    }

    private void LateUpdate()
    {
        if(_onUp)
            _camera.orthographicSize = _ortSize;
        if(!_onUp)
            _camera.orthographicSize = _oldOrtSize;
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        OnUpStares?.Invoke();
        _onUp = true;
    }
    private void OnTriggerExit2D(Collider2D col)
    {
        OnDownStares?.Invoke();
        _onUp = false;
    }
}