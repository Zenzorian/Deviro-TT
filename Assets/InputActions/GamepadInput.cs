//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.14.0
//     from Assets/InputActions/GamepadInput.inputactions
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

/// <summary>
/// Provides programmatic access to <see cref="InputActionAsset" />, <see cref="InputActionMap" />, <see cref="InputAction" /> and <see cref="InputControlScheme" /> instances defined in asset "Assets/InputActions/GamepadInput.inputactions".
/// </summary>
/// <remarks>
/// This class is source generated and any manual edits will be discarded if the associated asset is reimported or modified.
/// </remarks>
/// <example>
/// <code>
/// using namespace UnityEngine;
/// using UnityEngine.InputSystem;
///
/// // Example of using an InputActionMap named "Player" from a UnityEngine.MonoBehaviour implementing callback interface.
/// public class Example : MonoBehaviour, MyActions.IPlayerActions
/// {
///     private MyActions_Actions m_Actions;                  // Source code representation of asset.
///     private MyActions_Actions.PlayerActions m_Player;     // Source code representation of action map.
///
///     void Awake()
///     {
///         m_Actions = new MyActions_Actions();              // Create asset object.
///         m_Player = m_Actions.Player;                      // Extract action map object.
///         m_Player.AddCallbacks(this);                      // Register callback interface IPlayerActions.
///     }
///
///     void OnDestroy()
///     {
///         m_Actions.Dispose();                              // Destroy asset object.
///     }
///
///     void OnEnable()
///     {
///         m_Player.Enable();                                // Enable all actions within map.
///     }
///
///     void OnDisable()
///     {
///         m_Player.Disable();                               // Disable all actions within map.
///     }
///
///     #region Interface implementation of MyActions.IPlayerActions
///
///     // Invoked when "Move" action is either started, performed or canceled.
///     public void OnMove(InputAction.CallbackContext context)
///     {
///         Debug.Log($"OnMove: {context.ReadValue&lt;Vector2&gt;()}");
///     }
///
///     // Invoked when "Attack" action is either started, performed or canceled.
///     public void OnAttack(InputAction.CallbackContext context)
///     {
///         Debug.Log($"OnAttack: {context.ReadValue&lt;float&gt;()}");
///     }
///
///     #endregion
/// }
/// </code>
/// </example>
public partial class @GamepadInput: IInputActionCollection2, IDisposable
{
    /// <summary>
    /// Provides access to the underlying asset instance.
    /// </summary>
    public InputActionAsset asset { get; }

    /// <summary>
    /// Constructs a new instance.
    /// </summary>
    public @GamepadInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GamepadInput"",
    ""maps"": [
        {
            ""name"": ""Gamepad Control"",
            ""id"": ""47ab8a32-04ae-4f6a-82e0-0bff67ef05a3"",
            ""actions"": [
                {
                    ""name"": ""LeftStickMove"",
                    ""type"": ""Value"",
                    ""id"": ""cc25db88-c5b7-4ff6-bad7-8f7166d239a8"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""RightStickMove"",
                    ""type"": ""Value"",
                    ""id"": ""7ed2abd1-45d5-4f88-b6d7-1f658c300379"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""61aa2ce7-1d12-4fe5-ba96-9a0f586251b3"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftStickMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""30c9decb-6e92-4808-a464-1ae4da83cdb1"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightStickMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gamepad Control
        m_GamepadControl = asset.FindActionMap("Gamepad Control", throwIfNotFound: true);
        m_GamepadControl_LeftStickMove = m_GamepadControl.FindAction("LeftStickMove", throwIfNotFound: true);
        m_GamepadControl_RightStickMove = m_GamepadControl.FindAction("RightStickMove", throwIfNotFound: true);
    }

    ~@GamepadInput()
    {
        UnityEngine.Debug.Assert(!m_GamepadControl.enabled, "This will cause a leak and performance issues, GamepadInput.GamepadControl.Disable() has not been called.");
    }

    /// <summary>
    /// Destroys this asset and all associated <see cref="InputAction"/> instances.
    /// </summary>
    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.bindingMask" />
    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.devices" />
    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.controlSchemes" />
    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.Contains(InputAction)" />
    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.GetEnumerator()" />
    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    /// <inheritdoc cref="IEnumerable.GetEnumerator()" />
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.Enable()" />
    public void Enable()
    {
        asset.Enable();
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.Disable()" />
    public void Disable()
    {
        asset.Disable();
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.bindings" />
    public IEnumerable<InputBinding> bindings => asset.bindings;

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.FindAction(string, bool)" />
    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.FindBinding(InputBinding, out InputAction)" />
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Gamepad Control
    private readonly InputActionMap m_GamepadControl;
    private List<IGamepadControlActions> m_GamepadControlActionsCallbackInterfaces = new List<IGamepadControlActions>();
    private readonly InputAction m_GamepadControl_LeftStickMove;
    private readonly InputAction m_GamepadControl_RightStickMove;
    /// <summary>
    /// Provides access to input actions defined in input action map "Gamepad Control".
    /// </summary>
    public struct GamepadControlActions
    {
        private @GamepadInput m_Wrapper;

        /// <summary>
        /// Construct a new instance of the input action map wrapper class.
        /// </summary>
        public GamepadControlActions(@GamepadInput wrapper) { m_Wrapper = wrapper; }
        /// <summary>
        /// Provides access to the underlying input action "GamepadControl/LeftStickMove".
        /// </summary>
        public InputAction @LeftStickMove => m_Wrapper.m_GamepadControl_LeftStickMove;
        /// <summary>
        /// Provides access to the underlying input action "GamepadControl/RightStickMove".
        /// </summary>
        public InputAction @RightStickMove => m_Wrapper.m_GamepadControl_RightStickMove;
        /// <summary>
        /// Provides access to the underlying input action map instance.
        /// </summary>
        public InputActionMap Get() { return m_Wrapper.m_GamepadControl; }
        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionMap.Enable()" />
        public void Enable() { Get().Enable(); }
        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionMap.Disable()" />
        public void Disable() { Get().Disable(); }
        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionMap.enabled" />
        public bool enabled => Get().enabled;
        /// <summary>
        /// Implicitly converts an <see ref="GamepadControlActions" /> to an <see ref="InputActionMap" /> instance.
        /// </summary>
        public static implicit operator InputActionMap(GamepadControlActions set) { return set.Get(); }
        /// <summary>
        /// Adds <see cref="InputAction.started"/>, <see cref="InputAction.performed"/> and <see cref="InputAction.canceled"/> callbacks provided via <param cref="instance" /> on all input actions contained in this map.
        /// </summary>
        /// <param name="instance">Callback instance.</param>
        /// <remarks>
        /// If <paramref name="instance" /> is <c>null</c> or <paramref name="instance"/> have already been added this method does nothing.
        /// </remarks>
        /// <seealso cref="GamepadControlActions" />
        public void AddCallbacks(IGamepadControlActions instance)
        {
            if (instance == null || m_Wrapper.m_GamepadControlActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_GamepadControlActionsCallbackInterfaces.Add(instance);
            @LeftStickMove.started += instance.OnLeftStickMove;
            @LeftStickMove.performed += instance.OnLeftStickMove;
            @LeftStickMove.canceled += instance.OnLeftStickMove;
            @RightStickMove.started += instance.OnRightStickMove;
            @RightStickMove.performed += instance.OnRightStickMove;
            @RightStickMove.canceled += instance.OnRightStickMove;
        }

        /// <summary>
        /// Removes <see cref="InputAction.started"/>, <see cref="InputAction.performed"/> and <see cref="InputAction.canceled"/> callbacks provided via <param cref="instance" /> on all input actions contained in this map.
        /// </summary>
        /// <remarks>
        /// Calling this method when <paramref name="instance" /> have not previously been registered has no side-effects.
        /// </remarks>
        /// <seealso cref="GamepadControlActions" />
        private void UnregisterCallbacks(IGamepadControlActions instance)
        {
            @LeftStickMove.started -= instance.OnLeftStickMove;
            @LeftStickMove.performed -= instance.OnLeftStickMove;
            @LeftStickMove.canceled -= instance.OnLeftStickMove;
            @RightStickMove.started -= instance.OnRightStickMove;
            @RightStickMove.performed -= instance.OnRightStickMove;
            @RightStickMove.canceled -= instance.OnRightStickMove;
        }

        /// <summary>
        /// Unregisters <param cref="instance" /> and unregisters all input action callbacks via <see cref="GamepadControlActions.UnregisterCallbacks(IGamepadControlActions)" />.
        /// </summary>
        /// <seealso cref="GamepadControlActions.UnregisterCallbacks(IGamepadControlActions)" />
        public void RemoveCallbacks(IGamepadControlActions instance)
        {
            if (m_Wrapper.m_GamepadControlActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        /// <summary>
        /// Replaces all existing callback instances and previously registered input action callbacks associated with them with callbacks provided via <param cref="instance" />.
        /// </summary>
        /// <remarks>
        /// If <paramref name="instance" /> is <c>null</c>, calling this method will only unregister all existing callbacks but not register any new callbacks.
        /// </remarks>
        /// <seealso cref="GamepadControlActions.AddCallbacks(IGamepadControlActions)" />
        /// <seealso cref="GamepadControlActions.RemoveCallbacks(IGamepadControlActions)" />
        /// <seealso cref="GamepadControlActions.UnregisterCallbacks(IGamepadControlActions)" />
        public void SetCallbacks(IGamepadControlActions instance)
        {
            foreach (var item in m_Wrapper.m_GamepadControlActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_GamepadControlActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    /// <summary>
    /// Provides a new <see cref="GamepadControlActions" /> instance referencing this action map.
    /// </summary>
    public GamepadControlActions @GamepadControl => new GamepadControlActions(this);
    /// <summary>
    /// Interface to implement callback methods for all input action callbacks associated with input actions defined by "Gamepad Control" which allows adding and removing callbacks.
    /// </summary>
    /// <seealso cref="GamepadControlActions.AddCallbacks(IGamepadControlActions)" />
    /// <seealso cref="GamepadControlActions.RemoveCallbacks(IGamepadControlActions)" />
    public interface IGamepadControlActions
    {
        /// <summary>
        /// Method invoked when associated input action "LeftStickMove" is either <see cref="UnityEngine.InputSystem.InputAction.started" />, <see cref="UnityEngine.InputSystem.InputAction.performed" /> or <see cref="UnityEngine.InputSystem.InputAction.canceled" />.
        /// </summary>
        /// <seealso cref="UnityEngine.InputSystem.InputAction.started" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.performed" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.canceled" />
        void OnLeftStickMove(InputAction.CallbackContext context);
        /// <summary>
        /// Method invoked when associated input action "RightStickMove" is either <see cref="UnityEngine.InputSystem.InputAction.started" />, <see cref="UnityEngine.InputSystem.InputAction.performed" /> or <see cref="UnityEngine.InputSystem.InputAction.canceled" />.
        /// </summary>
        /// <seealso cref="UnityEngine.InputSystem.InputAction.started" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.performed" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.canceled" />
        void OnRightStickMove(InputAction.CallbackContext context);
    }
}
