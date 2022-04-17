using UnityEngine;
using UnityEngine.Events;

public class GlobalEventManager
{
        public static UnityEvent<int> EnemyKilled = new UnityEvent<int>();
        public static UnityEvent<Weapon, RaycastHit> RaycastVisit = new UnityEvent<Weapon, RaycastHit>();
        public static UnityEvent<Weapon> OverlapVisit = new UnityEvent<Weapon>();
        
        public static void OnEnemyKilled(int killed) => EnemyKilled.Invoke(killed);
        public static void OnOverlapVisit(Weapon weapon) => OverlapVisit.Invoke(weapon);
        public static void OnRaycastVisit(Weapon weapon, RaycastHit hit) => RaycastVisit.Invoke(weapon, hit);
}
