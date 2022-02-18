using UnityEngine;
using UnityEngine.Events;

public class GlobalEventManager
{
        public static UnityEvent<int> OnEnemyKilled = new UnityEvent<int>();
        
        public static void OnEnemyKilling(int killed) => OnEnemyKilled.Invoke(killed);
}
