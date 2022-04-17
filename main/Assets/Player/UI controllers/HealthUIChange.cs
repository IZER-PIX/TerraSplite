using UnityEngine.UI;
using UnityEngine;

public class HealthUIChange : MonoBehaviour
{
    [SerializeField] private Player @Player;

    private void Awake() {
        DisplayHealth(0);
        PlayerEventManager.OnTakeDamage.AddListener(DisplayHealth);
        PlayerEventManager.OnHeal.AddListener(DisplayHealth);
        PlayerEventManager.OnLevelIncerase.AddListener(DisplayHealth);
    }

    private void DisplayHealth(int health){
        GetComponent<Slider>().value = @Player.Health * 0.01f;
    }
}
