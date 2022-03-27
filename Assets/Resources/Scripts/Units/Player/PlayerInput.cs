//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.2.0
//     from Assets/Resources/Scripts/Units/Player/PlayerInput.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerInput : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""PlayerMovement"",
            ""id"": ""e99d3f8a-e6f4-43f4-8602-e645b2f038f6"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""b6d5e088-2483-4e7c-bdc9-be1103d602d2"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Dash"",
                    ""type"": ""Button"",
                    ""id"": ""5d48a90e-2dde-445d-8aaa-ab5718ab79ca"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Use Weapon"",
                    ""type"": ""Button"",
                    ""id"": ""62d649ca-f797-416e-b1bb-8a8b7807bdf8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Use First Skill"",
                    ""type"": ""Button"",
                    ""id"": ""f836abc6-0d5c-4888-9327-e1722a68b7a9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Use Second Skill"",
                    ""type"": ""Button"",
                    ""id"": ""777f4911-d189-44a4-8412-608cba922077"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Use Third Skill"",
                    ""type"": ""Button"",
                    ""id"": ""7924ebeb-cd9a-449e-9904-4bdd149cc4cb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Use Ultimate"",
                    ""type"": ""Button"",
                    ""id"": ""5762b3eb-981f-4acd-97d6-b767dc0f94f2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""bfc2fc0d-d6b0-4b15-b45c-eeddda49abd3"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""a019a9fd-0706-4510-b3e8-96a8015867ad"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""1fdce023-b4d2-4f57-9d6a-f04bd92ab59e"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""0408f09f-4a08-4645-bcda-ec6458382be3"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""10c49a43-dbc6-4dc4-b5e0-ef13e4549e6a"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""a889b1f2-fd27-420b-8991-7a6fab65811b"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1de98f6b-bcb4-4c2f-9d4e-448b3e0c9ea6"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Use Weapon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b5a647eb-e1c2-47a0-866f-491c0034869c"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Use First Skill"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b4ee072d-f901-4663-a98e-948f31401b00"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Use Second Skill"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""add0eebf-ebc5-4588-9854-c248bb3bee7a"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Use Third Skill"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4da0f78a-fa64-46bb-8079-5b4d6c409880"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Use Ultimate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard and Mouse"",
            ""bindingGroup"": ""Keyboard and Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // PlayerMovement
        m_PlayerMovement = asset.FindActionMap("PlayerMovement", throwIfNotFound: true);
        m_PlayerMovement_Movement = m_PlayerMovement.FindAction("Movement", throwIfNotFound: true);
        m_PlayerMovement_Dash = m_PlayerMovement.FindAction("Dash", throwIfNotFound: true);
        m_PlayerMovement_UseWeapon = m_PlayerMovement.FindAction("Use Weapon", throwIfNotFound: true);
        m_PlayerMovement_UseFirstSkill = m_PlayerMovement.FindAction("Use First Skill", throwIfNotFound: true);
        m_PlayerMovement_UseSecondSkill = m_PlayerMovement.FindAction("Use Second Skill", throwIfNotFound: true);
        m_PlayerMovement_UseThirdSkill = m_PlayerMovement.FindAction("Use Third Skill", throwIfNotFound: true);
        m_PlayerMovement_UseUltimate = m_PlayerMovement.FindAction("Use Ultimate", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // PlayerMovement
    private readonly InputActionMap m_PlayerMovement;
    private IPlayerMovementActions m_PlayerMovementActionsCallbackInterface;
    private readonly InputAction m_PlayerMovement_Movement;
    private readonly InputAction m_PlayerMovement_Dash;
    private readonly InputAction m_PlayerMovement_UseWeapon;
    private readonly InputAction m_PlayerMovement_UseFirstSkill;
    private readonly InputAction m_PlayerMovement_UseSecondSkill;
    private readonly InputAction m_PlayerMovement_UseThirdSkill;
    private readonly InputAction m_PlayerMovement_UseUltimate;
    public struct PlayerMovementActions
    {
        private @PlayerInput m_Wrapper;
        public PlayerMovementActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_PlayerMovement_Movement;
        public InputAction @Dash => m_Wrapper.m_PlayerMovement_Dash;
        public InputAction @UseWeapon => m_Wrapper.m_PlayerMovement_UseWeapon;
        public InputAction @UseFirstSkill => m_Wrapper.m_PlayerMovement_UseFirstSkill;
        public InputAction @UseSecondSkill => m_Wrapper.m_PlayerMovement_UseSecondSkill;
        public InputAction @UseThirdSkill => m_Wrapper.m_PlayerMovement_UseThirdSkill;
        public InputAction @UseUltimate => m_Wrapper.m_PlayerMovement_UseUltimate;
        public InputActionMap Get() { return m_Wrapper.m_PlayerMovement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerMovementActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerMovementActions instance)
        {
            if (m_Wrapper.m_PlayerMovementActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnMovement;
                @Dash.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnDash;
                @Dash.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnDash;
                @Dash.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnDash;
                @UseWeapon.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnUseWeapon;
                @UseWeapon.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnUseWeapon;
                @UseWeapon.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnUseWeapon;
                @UseFirstSkill.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnUseFirstSkill;
                @UseFirstSkill.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnUseFirstSkill;
                @UseFirstSkill.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnUseFirstSkill;
                @UseSecondSkill.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnUseSecondSkill;
                @UseSecondSkill.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnUseSecondSkill;
                @UseSecondSkill.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnUseSecondSkill;
                @UseThirdSkill.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnUseThirdSkill;
                @UseThirdSkill.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnUseThirdSkill;
                @UseThirdSkill.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnUseThirdSkill;
                @UseUltimate.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnUseUltimate;
                @UseUltimate.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnUseUltimate;
                @UseUltimate.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnUseUltimate;
            }
            m_Wrapper.m_PlayerMovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Dash.started += instance.OnDash;
                @Dash.performed += instance.OnDash;
                @Dash.canceled += instance.OnDash;
                @UseWeapon.started += instance.OnUseWeapon;
                @UseWeapon.performed += instance.OnUseWeapon;
                @UseWeapon.canceled += instance.OnUseWeapon;
                @UseFirstSkill.started += instance.OnUseFirstSkill;
                @UseFirstSkill.performed += instance.OnUseFirstSkill;
                @UseFirstSkill.canceled += instance.OnUseFirstSkill;
                @UseSecondSkill.started += instance.OnUseSecondSkill;
                @UseSecondSkill.performed += instance.OnUseSecondSkill;
                @UseSecondSkill.canceled += instance.OnUseSecondSkill;
                @UseThirdSkill.started += instance.OnUseThirdSkill;
                @UseThirdSkill.performed += instance.OnUseThirdSkill;
                @UseThirdSkill.canceled += instance.OnUseThirdSkill;
                @UseUltimate.started += instance.OnUseUltimate;
                @UseUltimate.performed += instance.OnUseUltimate;
                @UseUltimate.canceled += instance.OnUseUltimate;
            }
        }
    }
    public PlayerMovementActions @PlayerMovement => new PlayerMovementActions(this);
    private int m_KeyboardandMouseSchemeIndex = -1;
    public InputControlScheme KeyboardandMouseScheme
    {
        get
        {
            if (m_KeyboardandMouseSchemeIndex == -1) m_KeyboardandMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard and Mouse");
            return asset.controlSchemes[m_KeyboardandMouseSchemeIndex];
        }
    }
    public interface IPlayerMovementActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnDash(InputAction.CallbackContext context);
        void OnUseWeapon(InputAction.CallbackContext context);
        void OnUseFirstSkill(InputAction.CallbackContext context);
        void OnUseSecondSkill(InputAction.CallbackContext context);
        void OnUseThirdSkill(InputAction.CallbackContext context);
        void OnUseUltimate(InputAction.CallbackContext context);
    }
}