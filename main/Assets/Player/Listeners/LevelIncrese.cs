using UnityEngine;

public class LevelIncrese : MonoBehaviour {
    [SerializeField] private Player @Player;

    private void Awake() {
        PlayerEventManager.OnLevelIncerase.AddListener(IncreseLevel);
    }

    private void IncreseLevel(int xpBoost){
        int _levelIncreseOffset = 6 * @Player.Level;
        @Player.LevelPoints += xpBoost;

        if (@Player.LevelPoints >= _levelIncreseOffset){
            @Player.Level += 1;
            @Player.Health += 10;
        }
        Debug.Log(_levelIncreseOffset);
    }
}