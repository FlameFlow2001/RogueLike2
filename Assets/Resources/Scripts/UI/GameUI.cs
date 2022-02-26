using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    private GameObject player;
    private PlayerStats playerStats;
    [SerializeField] private Slider healthSlider;
    [SerializeField] private Text healthValue;
    [SerializeField] private Text coinValue;

    private void Start()
    {
        player = GameObject.Find("Player");
        playerStats = player.GetComponent<PlayerStats>();
    }

    
    public void SetHealthUI()
    {
        healthSlider.value = playerStats.CalculateHealthPercentage();
        healthValue.text = playerStats.health.ToString() + "/" + playerStats.maxHealth.ToString();
    }

    public void SetCoinsUI()
    {
        coinValue.text = playerStats.coins.ToString();
    }
}
