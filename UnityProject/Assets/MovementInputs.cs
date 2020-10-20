// GENERATED AUTOMATICALLY FROM 'Assets/MovementInputs.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @MovementInputs : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @MovementInputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""MovementInputs"",
    ""maps"": [
        {
            ""name"": ""main"",
            ""id"": ""84a2c5b6-195c-4b1f-8f83-b249b1b80f12"",
            ""actions"": [
                {
                    ""name"": ""Vertical"",
                    ""type"": ""Value"",
                    ""id"": ""22c2df65-860b-4a0a-a266-e9b7d85cb8ad"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Horizontal"",
                    ""type"": ""Value"",
                    ""id"": ""81ab46d9-2d27-45b6-97ef-7fdd207d34e2"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""f77db03f-40dd-4427-9888-f79ce68461f9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pickup"",
                    ""type"": ""Button"",
                    ""id"": ""458c6a04-1818-4080-bc41-4fa9d66bdf33"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""41e3553d-49f3-4aab-8f6f-2e3527cf2be5"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""e335a5fc-b7ce-4938-a1ad-487cbb3bc6ef"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""06a85789-c451-4829-80f5-24242f4bd255"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""7a2f3c4d-a3aa-48d1-9bb3-38d328ec29b8"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""41f3c1c5-46bb-47a5-9dc3-fd07b48d1741"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""1c299a54-daeb-455f-8da6-185ce876897e"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""4b0ab3d2-6d28-4d85-a1ac-1c4a29b8a723"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e71e2f0c-5cfe-4a85-b810-4236da9f29c9"",
                    ""path"": ""<Keyboard>/g"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pickup"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // main
        m_main = asset.FindActionMap("main", throwIfNotFound: true);
        m_main_Vertical = m_main.FindAction("Vertical", throwIfNotFound: true);
        m_main_Horizontal = m_main.FindAction("Horizontal", throwIfNotFound: true);
        m_main_Jump = m_main.FindAction("Jump", throwIfNotFound: true);
        m_main_Pickup = m_main.FindAction("Pickup", throwIfNotFound: true);
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

    // main
    private readonly InputActionMap m_main;
    private IMainActions m_MainActionsCallbackInterface;
    private readonly InputAction m_main_Vertical;
    private readonly InputAction m_main_Horizontal;
    private readonly InputAction m_main_Jump;
    private readonly InputAction m_main_Pickup;
    public struct MainActions
    {
        private @MovementInputs m_Wrapper;
        public MainActions(@MovementInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Vertical => m_Wrapper.m_main_Vertical;
        public InputAction @Horizontal => m_Wrapper.m_main_Horizontal;
        public InputAction @Jump => m_Wrapper.m_main_Jump;
        public InputAction @Pickup => m_Wrapper.m_main_Pickup;
        public InputActionMap Get() { return m_Wrapper.m_main; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MainActions set) { return set.Get(); }
        public void SetCallbacks(IMainActions instance)
        {
            if (m_Wrapper.m_MainActionsCallbackInterface != null)
            {
                @Vertical.started -= m_Wrapper.m_MainActionsCallbackInterface.OnVertical;
                @Vertical.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnVertical;
                @Vertical.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnVertical;
                @Horizontal.started -= m_Wrapper.m_MainActionsCallbackInterface.OnHorizontal;
                @Horizontal.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnHorizontal;
                @Horizontal.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnHorizontal;
                @Jump.started -= m_Wrapper.m_MainActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnJump;
                @Pickup.started -= m_Wrapper.m_MainActionsCallbackInterface.OnPickup;
                @Pickup.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnPickup;
                @Pickup.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnPickup;
            }
            m_Wrapper.m_MainActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Vertical.started += instance.OnVertical;
                @Vertical.performed += instance.OnVertical;
                @Vertical.canceled += instance.OnVertical;
                @Horizontal.started += instance.OnHorizontal;
                @Horizontal.performed += instance.OnHorizontal;
                @Horizontal.canceled += instance.OnHorizontal;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Pickup.started += instance.OnPickup;
                @Pickup.performed += instance.OnPickup;
                @Pickup.canceled += instance.OnPickup;
            }
        }
    }
    public MainActions @main => new MainActions(this);
    public interface IMainActions
    {
        void OnVertical(InputAction.CallbackContext context);
        void OnHorizontal(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnPickup(InputAction.CallbackContext context);
    }
}
