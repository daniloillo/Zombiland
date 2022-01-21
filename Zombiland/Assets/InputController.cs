// GENERATED AUTOMATICALLY FROM 'Assets/InputController.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputController : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputController()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputController"",
    ""maps"": [
        {
            ""name"": ""Movimiento"",
            ""id"": ""4f787679-5efb-48c7-b91b-83e41c31d667"",
            ""actions"": [
                {
                    ""name"": ""Saltar"",
                    ""type"": ""Button"",
                    ""id"": ""90a76657-f7d5-4dcf-a751-ff264778c997"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Agacharse"",
                    ""type"": ""Button"",
                    ""id"": ""448c0417-372a-456c-a630-b21d18a8b335"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Moverse"",
                    ""type"": ""Value"",
                    ""id"": ""a9c170f4-9027-40a2-bf7e-7c345169036c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""StrafeL"",
                    ""type"": ""Value"",
                    ""id"": ""ab60a05c-8015-419a-90b3-b7e9581cf66c"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""StrafeR"",
                    ""type"": ""Value"",
                    ""id"": ""3ed604d4-721b-4523-9d34-c0e3d10adf37"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""aa758910-102d-4810-a830-d6feef96baee"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Saltar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3770e021-14fd-467c-903c-b4256aefca3d"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Saltar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""32976b30-7dd2-4a07-a57a-1c7fdec532ea"",
                    ""path"": ""<XInputController>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Agacharse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""31367a2e-41bb-4f9a-b3fc-4a982991eaf8"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Agacharse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8a685286-2b54-4062-8c04-37d43b0d979b"",
                    ""path"": ""<XInputController>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Moverse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d3cb704b-d885-48ae-bc78-8e2cedce9a02"",
                    ""path"": ""<XInputController>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""StrafeL"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7a063868-44d1-459b-9cb7-021efee4c6da"",
                    ""path"": ""<XInputController>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""StrafeR"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Camara"",
            ""id"": ""ccf604ba-3679-4948-88ed-e182e394227b"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""312ca885-381a-4091-8da8-28cf906babb4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""6fc0ee1e-1926-4572-941f-cd38e5df5a4d"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Movimiento
        m_Movimiento = asset.FindActionMap("Movimiento", throwIfNotFound: true);
        m_Movimiento_Saltar = m_Movimiento.FindAction("Saltar", throwIfNotFound: true);
        m_Movimiento_Agacharse = m_Movimiento.FindAction("Agacharse", throwIfNotFound: true);
        m_Movimiento_Moverse = m_Movimiento.FindAction("Moverse", throwIfNotFound: true);
        m_Movimiento_StrafeL = m_Movimiento.FindAction("StrafeL", throwIfNotFound: true);
        m_Movimiento_StrafeR = m_Movimiento.FindAction("StrafeR", throwIfNotFound: true);
        // Camara
        m_Camara = asset.FindActionMap("Camara", throwIfNotFound: true);
        m_Camara_Newaction = m_Camara.FindAction("New action", throwIfNotFound: true);
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

    // Movimiento
    private readonly InputActionMap m_Movimiento;
    private IMovimientoActions m_MovimientoActionsCallbackInterface;
    private readonly InputAction m_Movimiento_Saltar;
    private readonly InputAction m_Movimiento_Agacharse;
    private readonly InputAction m_Movimiento_Moverse;
    private readonly InputAction m_Movimiento_StrafeL;
    private readonly InputAction m_Movimiento_StrafeR;
    public struct MovimientoActions
    {
        private @InputController m_Wrapper;
        public MovimientoActions(@InputController wrapper) { m_Wrapper = wrapper; }
        public InputAction @Saltar => m_Wrapper.m_Movimiento_Saltar;
        public InputAction @Agacharse => m_Wrapper.m_Movimiento_Agacharse;
        public InputAction @Moverse => m_Wrapper.m_Movimiento_Moverse;
        public InputAction @StrafeL => m_Wrapper.m_Movimiento_StrafeL;
        public InputAction @StrafeR => m_Wrapper.m_Movimiento_StrafeR;
        public InputActionMap Get() { return m_Wrapper.m_Movimiento; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovimientoActions set) { return set.Get(); }
        public void SetCallbacks(IMovimientoActions instance)
        {
            if (m_Wrapper.m_MovimientoActionsCallbackInterface != null)
            {
                @Saltar.started -= m_Wrapper.m_MovimientoActionsCallbackInterface.OnSaltar;
                @Saltar.performed -= m_Wrapper.m_MovimientoActionsCallbackInterface.OnSaltar;
                @Saltar.canceled -= m_Wrapper.m_MovimientoActionsCallbackInterface.OnSaltar;
                @Agacharse.started -= m_Wrapper.m_MovimientoActionsCallbackInterface.OnAgacharse;
                @Agacharse.performed -= m_Wrapper.m_MovimientoActionsCallbackInterface.OnAgacharse;
                @Agacharse.canceled -= m_Wrapper.m_MovimientoActionsCallbackInterface.OnAgacharse;
                @Moverse.started -= m_Wrapper.m_MovimientoActionsCallbackInterface.OnMoverse;
                @Moverse.performed -= m_Wrapper.m_MovimientoActionsCallbackInterface.OnMoverse;
                @Moverse.canceled -= m_Wrapper.m_MovimientoActionsCallbackInterface.OnMoverse;
                @StrafeL.started -= m_Wrapper.m_MovimientoActionsCallbackInterface.OnStrafeL;
                @StrafeL.performed -= m_Wrapper.m_MovimientoActionsCallbackInterface.OnStrafeL;
                @StrafeL.canceled -= m_Wrapper.m_MovimientoActionsCallbackInterface.OnStrafeL;
                @StrafeR.started -= m_Wrapper.m_MovimientoActionsCallbackInterface.OnStrafeR;
                @StrafeR.performed -= m_Wrapper.m_MovimientoActionsCallbackInterface.OnStrafeR;
                @StrafeR.canceled -= m_Wrapper.m_MovimientoActionsCallbackInterface.OnStrafeR;
            }
            m_Wrapper.m_MovimientoActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Saltar.started += instance.OnSaltar;
                @Saltar.performed += instance.OnSaltar;
                @Saltar.canceled += instance.OnSaltar;
                @Agacharse.started += instance.OnAgacharse;
                @Agacharse.performed += instance.OnAgacharse;
                @Agacharse.canceled += instance.OnAgacharse;
                @Moverse.started += instance.OnMoverse;
                @Moverse.performed += instance.OnMoverse;
                @Moverse.canceled += instance.OnMoverse;
                @StrafeL.started += instance.OnStrafeL;
                @StrafeL.performed += instance.OnStrafeL;
                @StrafeL.canceled += instance.OnStrafeL;
                @StrafeR.started += instance.OnStrafeR;
                @StrafeR.performed += instance.OnStrafeR;
                @StrafeR.canceled += instance.OnStrafeR;
            }
        }
    }
    public MovimientoActions @Movimiento => new MovimientoActions(this);

    // Camara
    private readonly InputActionMap m_Camara;
    private ICamaraActions m_CamaraActionsCallbackInterface;
    private readonly InputAction m_Camara_Newaction;
    public struct CamaraActions
    {
        private @InputController m_Wrapper;
        public CamaraActions(@InputController wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_Camara_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_Camara; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CamaraActions set) { return set.Get(); }
        public void SetCallbacks(ICamaraActions instance)
        {
            if (m_Wrapper.m_CamaraActionsCallbackInterface != null)
            {
                @Newaction.started -= m_Wrapper.m_CamaraActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_CamaraActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_CamaraActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_CamaraActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public CamaraActions @Camara => new CamaraActions(this);
    public interface IMovimientoActions
    {
        void OnSaltar(InputAction.CallbackContext context);
        void OnAgacharse(InputAction.CallbackContext context);
        void OnMoverse(InputAction.CallbackContext context);
        void OnStrafeL(InputAction.CallbackContext context);
        void OnStrafeR(InputAction.CallbackContext context);
    }
    public interface ICamaraActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
}
