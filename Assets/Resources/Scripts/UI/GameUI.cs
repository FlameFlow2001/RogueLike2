using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    private PlayerStats playerStats;
    [SerializeField] private Slider healthSlider;
    [SerializeField] private Text healthValue;
    [SerializeField] private Text coinValue;

    private void Start()
    {
        playerStats = GameObject.Find("Player").GetComponent<PlayerStats>();
        if (!playerStats)
            Debug.Log("Player Stats are not set. Check if there is an object called \"Player\" with script \"PlayerStats\" in the scene");
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
