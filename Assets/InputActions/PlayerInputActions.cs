//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.11.1
//     from Assets/InputActions/PlayerInputActions.inputactions
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

public partial class @PlayerInputActions: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""265c38f5-dd18-4d34-b198-aec58e1627ff"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""50fd2809-3aa3-4a90-988e-1facf6773553"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""PunchLeft"",
                    ""type"": ""Button"",
                    ""id"": ""8b9a08df-6bf7-4695-bf65-1a896cabdc98"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PunchRight"",
                    ""type"": ""Button"",
                    ""id"": ""cd6c89ac-440d-4a1b-a515-9be8d1153efe"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PunchUp"",
                    ""type"": ""Button"",
                    ""id"": ""06649c4b-f947-4934-a87d-84ff8759bcf7"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PunchDown"",
                    ""type"": ""Button"",
                    ""id"": ""8af85658-9b41-4e49-afd6-e99ec0a6a64e"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PunchFront"",
                    ""type"": ""Button"",
                    ""id"": ""3c79e410-dbfc-437c-8d2b-0cc2344f3da9"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a70d9922-f0f6-43c0-b25f-10f6ed27c689"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PunchLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""99722919-ee27-4606-9589-62aea2e8ae69"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PunchRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d0e8dc84-9cbd-4cd3-95f9-7ba2aabeb900"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PunchUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c4d42352-89e4-4a38-bab8-b521726fd409"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PunchDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""165b9b6d-3666-460e-80ca-0489079304a0"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PunchFront"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Dpad"",
                    ""id"": ""cefc16fc-557a-44b0-939f-2ad792876b07"",
                    ""path"": ""Dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Move = m_Player.FindAction("Move", throwIfNotFound: true);
        m_Player_PunchLeft = m_Player.FindAction("PunchLeft", throwIfNotFound: true);
        m_Player_PunchRight = m_Player.FindAction("PunchRight", throwIfNotFound: true);
        m_Player_PunchUp = m_Player.FindAction("PunchUp", throwIfNotFound: true);
        m_Player_PunchDown = m_Player.FindAction("PunchDown", throwIfNotFound: true);
        m_Player_PunchFront = m_Player.FindAction("PunchFront", throwIfNotFound: true);
    }

    ~@PlayerInputActions()
    {
        UnityEngine.Debug.Assert(!m_Player.enabled, "This will cause a leak and performance issues, PlayerInputActions.Player.Disable() has not been called.");
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

    // Player
    private readonly InputActionMap m_Player;
    private List<IPlayerActions> m_PlayerActionsCallbackInterfaces = new List<IPlayerActions>();
    private readonly InputAction m_Player_Move;
    private readonly InputAction m_Player_PunchLeft;
    private readonly InputAction m_Player_PunchRight;
    private readonly InputAction m_Player_PunchUp;
    private readonly InputAction m_Player_PunchDown;
    private readonly InputAction m_Player_PunchFront;
    public struct PlayerActions
    {
        private @PlayerInputActions m_Wrapper;
        public PlayerActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player_Move;
        public InputAction @PunchLeft => m_Wrapper.m_Player_PunchLeft;
        public InputAction @PunchRight => m_Wrapper.m_Player_PunchRight;
        public InputAction @PunchUp => m_Wrapper.m_Player_PunchUp;
        public InputAction @PunchDown => m_Wrapper.m_Player_PunchDown;
        public InputAction @PunchFront => m_Wrapper.m_Player_PunchFront;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
            @PunchLeft.started += instance.OnPunchLeft;
            @PunchLeft.performed += instance.OnPunchLeft;
            @PunchLeft.canceled += instance.OnPunchLeft;
            @PunchRight.started += instance.OnPunchRight;
            @PunchRight.performed += instance.OnPunchRight;
            @PunchRight.canceled += instance.OnPunchRight;
            @PunchUp.started += instance.OnPunchUp;
            @PunchUp.performed += instance.OnPunchUp;
            @PunchUp.canceled += instance.OnPunchUp;
            @PunchDown.started += instance.OnPunchDown;
            @PunchDown.performed += instance.OnPunchDown;
            @PunchDown.canceled += instance.OnPunchDown;
            @PunchFront.started += instance.OnPunchFront;
            @PunchFront.performed += instance.OnPunchFront;
            @PunchFront.canceled += instance.OnPunchFront;
        }

        private void UnregisterCallbacks(IPlayerActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
            @PunchLeft.started -= instance.OnPunchLeft;
            @PunchLeft.performed -= instance.OnPunchLeft;
            @PunchLeft.canceled -= instance.OnPunchLeft;
            @PunchRight.started -= instance.OnPunchRight;
            @PunchRight.performed -= instance.OnPunchRight;
            @PunchRight.canceled -= instance.OnPunchRight;
            @PunchUp.started -= instance.OnPunchUp;
            @PunchUp.performed -= instance.OnPunchUp;
            @PunchUp.canceled -= instance.OnPunchUp;
            @PunchDown.started -= instance.OnPunchDown;
            @PunchDown.performed -= instance.OnPunchDown;
            @PunchDown.canceled -= instance.OnPunchDown;
            @PunchFront.started -= instance.OnPunchFront;
            @PunchFront.performed -= instance.OnPunchFront;
            @PunchFront.canceled -= instance.OnPunchFront;
        }

        public void RemoveCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnPunchLeft(InputAction.CallbackContext context);
        void OnPunchRight(InputAction.CallbackContext context);
        void OnPunchUp(InputAction.CallbackContext context);
        void OnPunchDown(InputAction.CallbackContext context);
        void OnPunchFront(InputAction.CallbackContext context);
    }
}
