//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Player/PlayerActions.inputactions
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

public partial class @PlayerActions : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerActions"",
    ""maps"": [
        {
            ""name"": ""Move"",
            ""id"": ""676cd010-26c6-4827-aed6-585263537869"",
            ""actions"": [
                {
                    ""name"": ""WASD"",
                    ""type"": ""Value"",
                    ""id"": ""4d83db46-e0ab-467f-b662-6892420701bd"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""2225a284-bb14-4da5-882d-fe7ad6fb48cf"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""ef05c683-612b-4f9b-ad9d-6432c0ce0067"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""0f288ad1-873e-4c5c-9c67-09a7362d04a4"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""5432b153-977e-4db3-974a-2163e7287dec"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""195bac13-19cf-4b69-8372-4f233c4808fa"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Actions"",
            ""id"": ""70262e3f-5f3b-45d9-aecc-930f99f9f723"",
            ""actions"": [
                {
                    ""name"": ""RaycastAttack"",
                    ""type"": ""Button"",
                    ""id"": ""127237d8-43d2-4b91-b5c5-44e4fddebb65"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Action"",
                    ""type"": ""Button"",
                    ""id"": ""3c09e390-06fd-48bc-acc1-06193faae8a3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Reload"",
                    ""type"": ""Button"",
                    ""id"": ""c8866d4d-0b68-476a-a8a3-b9f8528f7d72"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""OverlapAttack"",
                    ""type"": ""Button"",
                    ""id"": ""b69528cb-e1d3-4fd5-8b73-883b73543be8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ShowPlayerStats"",
                    ""type"": ""Button"",
                    ""id"": ""5304a957-3010-4291-b4bb-175a953e102a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""acae7461-cc5b-482f-aca3-09312c435f4e"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RaycastAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ab3d195f-25fa-4407-9f4a-9b2fabf1a328"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""44be04c7-c27e-4708-be1c-6cf23bfe59ab"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reload"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""20464660-6dcc-41aa-a088-1a9e8485e472"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""OverlapAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cee6099b-59e4-4486-a397-8bc49c5eff0c"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShowPlayerStats"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Move
        m_Move = asset.FindActionMap("Move", throwIfNotFound: true);
        m_Move_WASD = m_Move.FindAction("WASD", throwIfNotFound: true);
        // Actions
        m_Actions = asset.FindActionMap("Actions", throwIfNotFound: true);
        m_Actions_RaycastAttack = m_Actions.FindAction("RaycastAttack", throwIfNotFound: true);
        m_Actions_Action = m_Actions.FindAction("Action", throwIfNotFound: true);
        m_Actions_Reload = m_Actions.FindAction("Reload", throwIfNotFound: true);
        m_Actions_OverlapAttack = m_Actions.FindAction("OverlapAttack", throwIfNotFound: true);
        m_Actions_ShowPlayerStats = m_Actions.FindAction("ShowPlayerStats", throwIfNotFound: true);
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

    // Move
    private readonly InputActionMap m_Move;
    private IMoveActions m_MoveActionsCallbackInterface;
    private readonly InputAction m_Move_WASD;
    public struct MoveActions
    {
        private @PlayerActions m_Wrapper;
        public MoveActions(@PlayerActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @WASD => m_Wrapper.m_Move_WASD;
        public InputActionMap Get() { return m_Wrapper.m_Move; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MoveActions set) { return set.Get(); }
        public void SetCallbacks(IMoveActions instance)
        {
            if (m_Wrapper.m_MoveActionsCallbackInterface != null)
            {
                @WASD.started -= m_Wrapper.m_MoveActionsCallbackInterface.OnWASD;
                @WASD.performed -= m_Wrapper.m_MoveActionsCallbackInterface.OnWASD;
                @WASD.canceled -= m_Wrapper.m_MoveActionsCallbackInterface.OnWASD;
            }
            m_Wrapper.m_MoveActionsCallbackInterface = instance;
            if (instance != null)
            {
                @WASD.started += instance.OnWASD;
                @WASD.performed += instance.OnWASD;
                @WASD.canceled += instance.OnWASD;
            }
        }
    }
    public MoveActions @Move => new MoveActions(this);

    // Actions
    private readonly InputActionMap m_Actions;
    private IActionsActions m_ActionsActionsCallbackInterface;
    private readonly InputAction m_Actions_RaycastAttack;
    private readonly InputAction m_Actions_Action;
    private readonly InputAction m_Actions_Reload;
    private readonly InputAction m_Actions_OverlapAttack;
    private readonly InputAction m_Actions_ShowPlayerStats;
    public struct ActionsActions
    {
        private @PlayerActions m_Wrapper;
        public ActionsActions(@PlayerActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @RaycastAttack => m_Wrapper.m_Actions_RaycastAttack;
        public InputAction @Action => m_Wrapper.m_Actions_Action;
        public InputAction @Reload => m_Wrapper.m_Actions_Reload;
        public InputAction @OverlapAttack => m_Wrapper.m_Actions_OverlapAttack;
        public InputAction @ShowPlayerStats => m_Wrapper.m_Actions_ShowPlayerStats;
        public InputActionMap Get() { return m_Wrapper.m_Actions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ActionsActions set) { return set.Get(); }
        public void SetCallbacks(IActionsActions instance)
        {
            if (m_Wrapper.m_ActionsActionsCallbackInterface != null)
            {
                @RaycastAttack.started -= m_Wrapper.m_ActionsActionsCallbackInterface.OnRaycastAttack;
                @RaycastAttack.performed -= m_Wrapper.m_ActionsActionsCallbackInterface.OnRaycastAttack;
                @RaycastAttack.canceled -= m_Wrapper.m_ActionsActionsCallbackInterface.OnRaycastAttack;
                @Action.started -= m_Wrapper.m_ActionsActionsCallbackInterface.OnAction;
                @Action.performed -= m_Wrapper.m_ActionsActionsCallbackInterface.OnAction;
                @Action.canceled -= m_Wrapper.m_ActionsActionsCallbackInterface.OnAction;
                @Reload.started -= m_Wrapper.m_ActionsActionsCallbackInterface.OnReload;
                @Reload.performed -= m_Wrapper.m_ActionsActionsCallbackInterface.OnReload;
                @Reload.canceled -= m_Wrapper.m_ActionsActionsCallbackInterface.OnReload;
                @OverlapAttack.started -= m_Wrapper.m_ActionsActionsCallbackInterface.OnOverlapAttack;
                @OverlapAttack.performed -= m_Wrapper.m_ActionsActionsCallbackInterface.OnOverlapAttack;
                @OverlapAttack.canceled -= m_Wrapper.m_ActionsActionsCallbackInterface.OnOverlapAttack;
                @ShowPlayerStats.started -= m_Wrapper.m_ActionsActionsCallbackInterface.OnShowPlayerStats;
                @ShowPlayerStats.performed -= m_Wrapper.m_ActionsActionsCallbackInterface.OnShowPlayerStats;
                @ShowPlayerStats.canceled -= m_Wrapper.m_ActionsActionsCallbackInterface.OnShowPlayerStats;
            }
            m_Wrapper.m_ActionsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @RaycastAttack.started += instance.OnRaycastAttack;
                @RaycastAttack.performed += instance.OnRaycastAttack;
                @RaycastAttack.canceled += instance.OnRaycastAttack;
                @Action.started += instance.OnAction;
                @Action.performed += instance.OnAction;
                @Action.canceled += instance.OnAction;
                @Reload.started += instance.OnReload;
                @Reload.performed += instance.OnReload;
                @Reload.canceled += instance.OnReload;
                @OverlapAttack.started += instance.OnOverlapAttack;
                @OverlapAttack.performed += instance.OnOverlapAttack;
                @OverlapAttack.canceled += instance.OnOverlapAttack;
                @ShowPlayerStats.started += instance.OnShowPlayerStats;
                @ShowPlayerStats.performed += instance.OnShowPlayerStats;
                @ShowPlayerStats.canceled += instance.OnShowPlayerStats;
            }
        }
    }
    public ActionsActions @Actions => new ActionsActions(this);
    public interface IMoveActions
    {
        void OnWASD(InputAction.CallbackContext context);
    }
    public interface IActionsActions
    {
        void OnRaycastAttack(InputAction.CallbackContext context);
        void OnAction(InputAction.CallbackContext context);
        void OnReload(InputAction.CallbackContext context);
        void OnOverlapAttack(InputAction.CallbackContext context);
        void OnShowPlayerStats(InputAction.CallbackContext context);
    }
}
