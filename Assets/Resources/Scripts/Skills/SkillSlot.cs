using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SkillSlot : MonoBehaviour
{
    [SerializeField] private GameObject uiSlot;
    [HideInInspector] public Image skillIcon;
    [HideInInspector] public TextMeshProUGUI cooldownText;
    [HideInInspector] public TextMeshProUGUI manacostText;

    private void Awake()
    {
        skillIcon = uiSlot.GetComponent<Image>();
        cooldownText = uiSlot.GetComponent<SkillSlotUI>().cooldownText;
        manacostText = uiSlot.GetComponent<SkillSlotUI>().manacostText;
    }
}