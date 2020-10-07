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
            ""id"": ""42eacfda-e984-49f3-ab58-454e6d980ab7"",
            ""actions"": [
                {
                    ""name"": ""w"",
                    ""type"": ""PassThrough"",
                    ""id"": ""897aa870-19c8-4074-8c57-67f1b1424116"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""a"",
                    ""type"": ""PassThrough"",
                    ""id"": ""e9d85762-bf1a-44e4-8c7a-db77b4fc0312"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""s"",
                    ""type"": ""PassThrough"",
                    ""id"": ""a743f254-eb7c-45bd-8f7e-9420886c9668"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""d"",
                    ""type"": ""PassThrough"",
                    ""id"": ""37815b19-41bf-45a8-921e-f45c8ecadde5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""space"",
                    ""type"": ""PassThrough"",
                    ""id"": ""bb4f91b8-b993-48d0-a9f2-233b1b738f0e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""b"",
                    ""type"": ""PassThrough"",
                    ""id"": ""bf5dd007-4b9b-45a5-beef-5042d0b97035"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f90130cd-a27c-4306-80c1-d0aef4a1ec03"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""w"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3be36d91-65b3-4c8d-92c0-b7b1c1fd9aee"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""a"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cf684356-b712-4e50-911f-a74f4e70a356"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""s"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""49cf7dbb-5a00-4f33-910b-a0dd2820cb55"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""d"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""20a07764-e6f8-4081-b3c7-39a954c05ccf"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""space"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f9cf884c-6b43-4fc4-a294-43977bb4be00"",
                    ""path"": ""<Keyboard>/b"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""b"",
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
    private int m_KeyboardandMouseSchemeIndex = -1;
    public InputControlScheme KeyboardandMouseScheme
    {
        get
        {
            if (m_KeyboardandMouseSchemeIndex == -1) m_KeyboardandMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard and Mouse");
            return asset.controlSchemes[m_KeyboardandMouseSchemeIndex];
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
