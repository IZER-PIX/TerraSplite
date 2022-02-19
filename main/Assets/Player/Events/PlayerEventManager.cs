using UnityEngine;
using UnityEngine.Events;

public static class PlayerEventManager{
    public static UnityEvent<int> OnHeal = new UnityEvent<int>();
    public static UnityEvent<int> OnTakeDamage = new UnityEvent<int>();
    public static UnityEvent<int> OnLevelIncerase = new UnityEvent<int>();
    
    public static void OnHealing(int healBoost) => OnHeal.Invoke(healBoost);
    public static void OnLevelIncerasing(int XP) => OnLevelIncerase.Invoke(XP);
}