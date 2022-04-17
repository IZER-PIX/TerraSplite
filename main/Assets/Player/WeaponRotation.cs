using UnityEngine.InputSystem;
using UnityEngine;

public class WeaponRotation : MonoBehaviour
{
    [SerializeField] private Transform Target;

    public void Update()
    {
        var direction = Utils.Vector3To2(Target.position) - Utils.Vector3To2(transform.position);

        var angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0f, 0f, angle);
    }
}
