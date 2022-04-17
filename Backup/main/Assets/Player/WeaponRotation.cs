using UnityEngine.InputSystem;
using UnityEngine;

public class WeaponRotation : MonoBehaviour
{
    public void Update(){
        var mouse = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        var direction = Utils.Vector3To2(mouse) - Utils.Vector3To2(transform.position);

        var angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0f, 0f, angle);
    }
}
