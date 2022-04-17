using UnityEngine;
using UnityEngine.UI;

public class LevelUIChange : MonoBehaviour
{
    [SerializeField] private Player @Player;

    private void Awake() {
        DisplayLevel(0);
        PlayerEventManager.OnLevelIncerase.AddListener(DisplayLevel);
    }

    private void DisplayLevel(int x){
        GetComponent<Text>().text = ""+@Player.Level;
    }
}
