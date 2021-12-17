// GENERATED AUTOMATICALLY FROM 'Assets/New Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @NewControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @NewControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""New Controls"",
    ""maps"": [
        {
            ""name"": ""play"",
            ""id"": ""f804d504-ecba-4051-978f-5871e82fce37"",
            ""actions"": [
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""c92da27e-d122-415a-bd5e-7b610c109b68"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Movement"",
                    ""type"": ""Button"",
                    ""id"": ""a5057f7a-3d3c-4da8-a8c3-3020dfd99351"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""9aa8f47d-371d-4768-b93d-2a238a7aca97"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""54382cf4-15f2-4171-a89c-937daf34db70"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""40645b66-3ba0-4d0f-afcb-d5331b91511b"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""8f4555d5-3874-4e0e-bb0e-f8cdadd24f9e"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // play
        m_play = asset.FindActionMap("play", throwIfNotFound: true);
        m_play_Fire = m_play.FindAction("Fire", throwIfNotFound: true);
        m_play_Movement = m_play.FindAction("Movement", throwIfNotFound: true);
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

    // play
    private readonly InputActionMap m_play;
    private IPlayActions m_PlayActionsCallbackInterface;
    private readonly InputAction m_play_Fire;
    private readonly InputAction m_play_Movement;
    public struct PlayActions
    {
        private @NewControls m_Wrapper;
        public PlayActions(@NewControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Fire => m_Wrapper.m_play_Fire;
        public InputAction @Movement => m_Wrapper.m_play_Movement;
        public InputActionMap Get() { return m_Wrapper.m_play; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayActions set) { return set.Get(); }
        public void SetCallbacks(IPlayActions instance)
        {
            if (m_Wrapper.m_PlayActionsCallbackInterface != null)
            {
                @Fire.started -= m_Wrapper.m_PlayActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_PlayActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_PlayActionsCallbackInterface.OnFire;
                @Movement.started -= m_Wrapper.m_PlayActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayActionsCallbackInterface.OnMovement;
            }
            m_Wrapper.m_PlayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
            }
        }
    }
    public PlayActions @play => new PlayActions(this);
    public interface IPlayActions
    {
        void OnFire(InputAction.CallbackContext context);
        void OnMovement(InputAction.CallbackContext context);
    }
}
