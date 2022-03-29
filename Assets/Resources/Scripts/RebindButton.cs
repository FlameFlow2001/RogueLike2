using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using TMPro;

public class RebindButton : MonoBehaviour
{
    [SerializeField] private InputActionReference inputActionRef;
    [SerializeField] private PlayerComponent playerComponent;
    [SerializeField] private TMP_Text buttonText;
    [SerializeField] private Button button;
    private Color normalColor;
    private Color pressedColor;
    
    
    private InputActionRebindingExtensions.RebindingOperation rebindingOperation;
    public void StartRebinding()
    {
        rebindingOperation = inputActionRef.action.PerformInteractiveRebinding()
                    .WithControlsExcluding("Mouse")
                    .OnMatchWaitForAnother(0.1f)
                    .OnComplete(operation => RebindComplete())
                    .Start();
    }

    private void RebindComplete()
    {
        int bindingIndex = inputActionRef.action.GetBindingIndexForControl(inputActionRef.action.controls[0]);
        buttonText.text = InputControlPath.ToHumanReadableString(inputActionRef.action.bindings[bindingIndex].effectivePath,
            InputControlPath.HumanReadableStringOptions.OmitDevice);
        rebindingOperation.Dispose();
        button.Select();
    }
}
