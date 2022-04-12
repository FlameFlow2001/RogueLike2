using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SkillSlotUI : MonoBehaviour
{
    [HideInInspector] public Image skillIconSlot;
    public TextMeshProUGUI cooldownText;
    public TextMeshProUGUI manacostText;

    private void Awake()
    {
        skillIconSlot = gameObject.GetComponent<Image>();
    }
}
