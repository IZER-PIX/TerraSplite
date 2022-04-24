using UnityEngine.UI;
using UnityEngine;

public class HealthUIChange : MonoBehaviour
{
    [SerializeField] private Player @Player;

    private void Awake() {
        DisplayHealth(0);
        PlayerEventManager.OnTakeDamage.AddListener(DisplayHealth);
        PlayerEventManager.OnHeal.AddListener(DisplayHealth);
    }

    private void Update()
    {
        DisplayHealth(0);
    }

    private void DisplayHealth(int health){
        GetComponent<Slider>().value = @Player.Health * 0.01f;
        // GetComponent<TextMeshProUGUI>().Text = @Player.Health;
    }
}
