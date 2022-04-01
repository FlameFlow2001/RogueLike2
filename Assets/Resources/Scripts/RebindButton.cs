using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using UnityEngine.EventSystems;

public class RebindButton : MonoBehaviour
{
    [SerializeField] private InputActionReference inputActionRef;
    [SerializeField] private TMP_Text buttonText;

    private InputActionRebindingExtensions.RebindingOperation rebindingOperation;
    private void Start()
    {
        buttonText.text = InputControlPath.ToHumanReadableString(inputActionRef.action.bindings[1].effectivePath,
            InputControlPath.HumanReadableStringOptions.OmitDevice);
    }

    public void StartRebinding()
    {
        rebindingOperation = inputActionRef.action.PerformInteractiveRebinding()
                    .WithCancelingThrough("<Keyboard>/escape")
                    .OnMatchWaitForAnother(0.1f)
                    .OnCancel(operation => RebindCancel())
                    .OnComplete(operation => RebindComplete())
                    .Start();
    }

    private void RebindComplete()
    {
        buttonText.text = InputControlPath.ToHumanReadableString(inputActionRef.action.bindings[1].effectivePath,
            InputControlPath.HumanReadableStringOptions.OmitDevice);
        rebindingOperation.Dispose();
        FindObjectOfType<EventSystem>().SetSelectedGameObject(null);
    }

    private void RebindCancel()
    {
        rebindingOperation.Dispose();
        FindObjectOfType<EventSystem>().SetSelectedGameObject(null);
    }
}
