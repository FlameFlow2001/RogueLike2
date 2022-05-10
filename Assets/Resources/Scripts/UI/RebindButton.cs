using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;
using TMPro;

public class RebindButton : MonoBehaviour
{
    [SerializeField] private InputActionReference inputActionRef;
    [SerializeField] private TMP_Text buttonText;
    [SerializeField] private int actionIndex = 0;
    private InputActionRebindingExtensions.RebindingOperation rebindingOperation;
    private void Start()
    {
        buttonText.text = InputControlPath.ToHumanReadableString(inputActionRef.action.bindings[actionIndex].effectivePath,
            InputControlPath.HumanReadableStringOptions.OmitDevice);
    }

    public void StartRebinding()
    {
        if (inputActionRef.action.bindings[actionIndex].isPartOfComposite)
        {
            Debug.Log(inputActionRef.action.bindings[actionIndex].path);
        }
        rebindingOperation = inputActionRef.action.PerformInteractiveRebinding(actionIndex)
        .WithCancelingThrough("<Keyboard>/escape")
        .OnMatchWaitForAnother(0.1f)
        .OnCancel(operation => RebindCancel())
        .OnComplete(operation => RebindComplete())
        .Start();
    }

    private void RebindComplete()
    {
        Debug.Log(inputActionRef.action.bindings[actionIndex].path);
        buttonText.text = InputControlPath.ToHumanReadableString(inputActionRef.action.bindings[actionIndex].effectivePath,
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
