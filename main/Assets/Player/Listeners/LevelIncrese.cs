using UnityEngine;

public class LevelIncrese : MonoBehaviour {
    private Player @Player;

    private void Awake() {
        @Player = GetComponent<Player>();
        PlayerEventManager.OnLevelIncerase.AddListener(IncreseLevel);
    }

    private void IncreseLevel(int xpBoost){
        int _levelIncreseOffset = 6 * @Player.Level;
        @Player.LevelPoints += xpBoost;

        if (@Player.LevelPoints >= _levelIncreseOffset)
            @Player.Level += 1;

    }
}