using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using UnityEngine.EventSystems;

public class RebindButton : MonoBehaviour
{
    [SerializeField] private InputActionReference inputActionRef;
    [SerializeField] private TMP_Text buttonText;
    private InputActionRebindingExtensions.RebindingOperation rebindingOperation;
    public void StartRebinding()
    {
        rebindingOperation = inputActionRef.action.PerformInteractiveRebinding()
                    .WithCancelingThrough("<Keyboard>/escape")
                    .WithControlsExcluding("Mouse")
                    .OnMatchWaitForAnother(0.1f)
                    .OnCancel(operation => FindObjectOfType<EventSystem>().SetSelectedGameObject(null))
                    .OnComplete(operation => RebindComplete())
                    .Start();
    }

    private void RebindComplete()
    {
        int bindingIndex = inputActionRef.action.GetBindingIndexForControl(inputActionRef.action.controls[0]);
        buttonText.text = InputControlPath.ToHumanReadableString(inputActionRef.action.bindings[bindingIndex].effectivePath,
            InputControlPath.HumanReadableStringOptions.OmitDevice);
        rebindingOperation.Dispose();
        FindObjectOfType<EventSystem>().SetSelectedGameObject(null);
    }
}
