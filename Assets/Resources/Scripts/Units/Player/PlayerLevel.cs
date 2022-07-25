using System.Collections.Generic;
using UnityEngine;

public class PlayerLevel : Level
{
    private PlayerComponent playerComponent;
    [HideInInspector] public int currentExp;
    public List<int> expForLevel = new List<int>() {0, 100, 220, 360, 600, 900, 1300, 1730 };

    private void Awake()
    {
        playerComponent = GetComponent<PlayerComponent>();
    }
    void Start()
    {
        lvlCap = expForLevel.Capacity;
    }

    private void CheckLvlUp()
    {
        if (currentExp >= expForLevel[currentLvl + 1])
        {
            lvlUp();
        }
    }
    public void AddExp(int amount)
    {
        currentExp += amount;
        CheckLvlUp();
        ((PlayerUI)playerComponent.unitUI).SetExpUI(currentExp, expForLevel[currentLvl], expForLevel[currentLvl + 1]);
    }
}
