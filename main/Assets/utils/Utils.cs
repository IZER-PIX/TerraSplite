using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public static class Utils
{
    public static Vector2 Vector3To2(Vector3 v3) => new Vector2(v3.x, v3.y);
    public static Vector3 Vector2To3(Vector2 v2) => new Vector3(v2.x, v2.y, 0f);
}
