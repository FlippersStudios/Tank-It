// GENERATED AUTOMATICALLY FROM 'Assets/PlayerInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""294d17ed-6c9d-40cc-a644-ae0b9a2a959f"",
            ""actions"": [
                {
                    ""name"": ""w"",
                    ""type"": ""PassThrough"",
                    ""id"": ""5c483dfe-d0ee-4cdd-a36d-42b911344c0f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""a"",
                    ""type"": ""PassThrough"",
                    ""id"": ""73d70ea3-8b15-452f-8ec8-8d8f477fffb7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""s"",
                    ""type"": ""PassThrough"",
                    ""id"": ""2e9d5b23-08d3-4010-85f8-7f8236349ff0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""d"",
                    ""type"": ""PassThrough"",
                    ""id"": ""a79ea2fd-b449-4049-922e-6086a5f2f1be"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""space"",
                    ""type"": ""PassThrough"",
                    ""id"": ""1886bf6c-0ea2-466d-9951-d78d8cb24b8c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""b"",
                    ""type"": ""PassThrough"",
                    ""id"": ""65a102c8-9b09-45f6-965b-bef290ef0ef6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""4a5a09ef-0d43-44c0-9fd8-b3da75178d1c"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""keyboard and mouse"",
                    ""action"": ""w"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2097884e-95e0-46ad-bf90-9b6ba2e44e2e"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""keyboard and mouse"",
                    ""action"": ""a"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0e71e23d-833e-4f8e-ab54-26ef234bc84d"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""keyboard and mouse"",
                    ""action"": ""s"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a509b8fa-2bff-4659-bba3-c3ce6333e0ed"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""keyboard and mouse"",
                    ""action"": ""d"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d61cca71-fbf7-4d1d-91cf-a47ca05796fa"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""keyboard and mouse"",
                    ""action"": ""space"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6d01600e-d806-41c2-860a-dd5459eb6145"",
                    ""path"": ""<Keyboard>/b"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""keyboard and mouse"",
                    ""action"": ""b"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""keyboard and mouse"",
            ""bindingGroup"": ""keyboard and mouse"",
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
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_w = m_Player.FindAction("w", throwIfNotFound: true);
        m_Player_a = m_Player.FindAction("a", throwIfNotFound: true);
        m_Player_s = m_Player.FindAction("s", throwIfNotFound: true);
        m_Player_d = m_Player.FindAction("d", throwIfNotFound: true);
        m_Player_space = m_Player.FindAction("space", throwIfNotFound: true);
        m_Player_b = m_Player.FindAction("b", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_w;
    private readonly InputAction m_Player_a;
    private readonly InputAction m_Player_s;
    private readonly InputAction m_Player_d;
    private readonly InputAction m_Player_space;
    private readonly InputAction m_Player_b;
    public struct PlayerActions
    {
        private @PlayerInput m_Wrapper;
        public PlayerActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @w => m_Wrapper.m_Player_w;
        public InputAction @a => m_Wrapper.m_Player_a;
        public InputAction @s => m_Wrapper.m_Player_s;
        public InputAction @d => m_Wrapper.m_Player_d;
        public InputAction @space => m_Wrapper.m_Player_space;
        public InputAction @b => m_Wrapper.m_Player_b;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @w.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnW;
                @w.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnW;
                @w.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnW;
                @a.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnA;
                @a.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnA;
                @a.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnA;
                @s.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnS;
                @s.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnS;
                @s.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnS;
                @d.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnD;
                @d.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnD;
                @d.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnD;
                @space.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSpace;
                @space.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSpace;
                @space.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSpace;
                @b.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnB;
                @b.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnB;
                @b.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnB;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @w.started += instance.OnW;
                @w.performed += instance.OnW;
                @w.canceled += instance.OnW;
                @a.started += instance.OnA;
                @a.performed += instance.OnA;
                @a.canceled += instance.OnA;
                @s.started += instance.OnS;
                @s.performed += instance.OnS;
                @s.canceled += instance.OnS;
                @d.started += instance.OnD;
                @d.performed += instance.OnD;
                @d.canceled += instance.OnD;
                @space.started += instance.OnSpace;
                @space.performed += instance.OnSpace;
                @space.canceled += instance.OnSpace;
                @b.started += instance.OnB;
                @b.performed += instance.OnB;
                @b.canceled += instance.OnB;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    private int m_keyboardandmouseSchemeIndex = -1;
    public InputControlScheme keyboardandmouseScheme
    {
        get
        {
            if (m_keyboardandmouseSchemeIndex == -1) m_keyboardandmouseSchemeIndex = asset.FindControlSchemeIndex("keyboard and mouse");
            return asset.controlSchemes[m_keyboardandmouseSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnW(InputAction.CallbackContext context);
        void OnA(InputAction.CallbackContext context);
        void OnS(InputAction.CallbackContext context);
        void OnD(InputAction.CallbackContext context);
        void OnSpace(InputAction.CallbackContext context);
        void OnB(InputAction.CallbackContext context);
    }
}
