using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTracking : MonoBehaviour
{
    [SerializeField] private Transform Target;
    [SerializeField] private float SmoothSpeed;
    [SerializeField] private Vector3 Offset;

    private void LateUpdate() {
        Vector3 smoothPosition = Target.position + Offset;
        transform.position = Vector3.Lerp(transform.position, smoothPosition, SmoothSpeed);
    }
}
