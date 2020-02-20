// GENERATED AUTOMATICALLY FROM 'Assets/Scenes/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""GameplayJoystick"",
            ""id"": ""72b08968-8c8e-4831-b3ae-8440561227ed"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""1facc312-1b58-4c3f-90db-c6b938190a45"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotate"",
                    ""type"": ""Button"",
                    ""id"": ""352e5c94-52fc-4650-9935-689b2faf91d7"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c4edf62e-f732-4ac4-9ddd-55361bdb4e0e"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ab64fa8a-f37b-40cb-8f6a-e8d929c9143a"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""GameplayKeyboard"",
            ""id"": ""64d06f6e-8e4c-4fe0-b27f-eff09064b581"",
            ""actions"": [
                {
                    ""name"": ""MoveUp"",
                    ""type"": ""Button"",
                    ""id"": ""438312a9-46ac-47ac-b99e-10a372a22f77"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveLeft"",
                    ""type"": ""Button"",
                    ""id"": ""f215713b-f27e-4b87-9d25-a764511b7357"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveRight"",
                    ""type"": ""Button"",
                    ""id"": ""c15e6aee-d78a-42bd-8c60-e24262e92229"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveDown"",
                    ""type"": ""Button"",
                    ""id"": ""a871effc-4271-4089-9be6-8e2fc6b0d5bb"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""00e0e63d-4e49-4b4a-9015-8a2e9a684a97"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0c208add-cfc7-42ee-b5d6-2c8d7afdde40"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""19aa082c-5a0d-4012-b66b-9ea6274838f7"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""be0fdf99-7ee8-4236-bddf-c16dd582e6ba"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""72d5b953-cbe1-47fc-9c48-87ddec8c6009"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""01e5f31e-2512-4c46-b0d1-9c30fe31d9a5"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2c71133e-5d8e-4bbe-82ac-db993f0ebb95"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e0326829-77e7-424c-a12c-aae0716ff0fa"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // GameplayJoystick
        m_GameplayJoystick = asset.FindActionMap("GameplayJoystick", throwIfNotFound: true);
        m_GameplayJoystick_Move = m_GameplayJoystick.FindAction("Move", throwIfNotFound: true);
        m_GameplayJoystick_Rotate = m_GameplayJoystick.FindAction("Rotate", throwIfNotFound: true);
        // GameplayKeyboard
        m_GameplayKeyboard = asset.FindActionMap("GameplayKeyboard", throwIfNotFound: true);
        m_GameplayKeyboard_MoveUp = m_GameplayKeyboard.FindAction("MoveUp", throwIfNotFound: true);
        m_GameplayKeyboard_MoveLeft = m_GameplayKeyboard.FindAction("MoveLeft", throwIfNotFound: true);
        m_GameplayKeyboard_MoveRight = m_GameplayKeyboard.FindAction("MoveRight", throwIfNotFound: true);
        m_GameplayKeyboard_MoveDown = m_GameplayKeyboard.FindAction("MoveDown", throwIfNotFound: true);
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

    // GameplayJoystick
    private readonly InputActionMap m_GameplayJoystick;
    private IGameplayJoystickActions m_GameplayJoystickActionsCallbackInterface;
    private readonly InputAction m_GameplayJoystick_Move;
    private readonly InputAction m_GameplayJoystick_Rotate;
    public struct GameplayJoystickActions
    {
        private @PlayerControls m_Wrapper;
        public GameplayJoystickActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_GameplayJoystick_Move;
        public InputAction @Rotate => m_Wrapper.m_GameplayJoystick_Rotate;
        public InputActionMap Get() { return m_Wrapper.m_GameplayJoystick; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayJoystickActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayJoystickActions instance)
        {
            if (m_Wrapper.m_GameplayJoystickActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_GameplayJoystickActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_GameplayJoystickActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_GameplayJoystickActionsCallbackInterface.OnMove;
                @Rotate.started -= m_Wrapper.m_GameplayJoystickActionsCallbackInterface.OnRotate;
                @Rotate.performed -= m_Wrapper.m_GameplayJoystickActionsCallbackInterface.OnRotate;
                @Rotate.canceled -= m_Wrapper.m_GameplayJoystickActionsCallbackInterface.OnRotate;
            }
            m_Wrapper.m_GameplayJoystickActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Rotate.started += instance.OnRotate;
                @Rotate.performed += instance.OnRotate;
                @Rotate.canceled += instance.OnRotate;
            }
        }
    }
    public GameplayJoystickActions @GameplayJoystick => new GameplayJoystickActions(this);

    // GameplayKeyboard
    private readonly InputActionMap m_GameplayKeyboard;
    private IGameplayKeyboardActions m_GameplayKeyboardActionsCallbackInterface;
    private readonly InputAction m_GameplayKeyboard_MoveUp;
    private readonly InputAction m_GameplayKeyboard_MoveLeft;
    private readonly InputAction m_GameplayKeyboard_MoveRight;
    private readonly InputAction m_GameplayKeyboard_MoveDown;
    public struct GameplayKeyboardActions
    {
        private @PlayerControls m_Wrapper;
        public GameplayKeyboardActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveUp => m_Wrapper.m_GameplayKeyboard_MoveUp;
        public InputAction @MoveLeft => m_Wrapper.m_GameplayKeyboard_MoveLeft;
        public InputAction @MoveRight => m_Wrapper.m_GameplayKeyboard_MoveRight;
        public InputAction @MoveDown => m_Wrapper.m_GameplayKeyboard_MoveDown;
        public InputActionMap Get() { return m_Wrapper.m_GameplayKeyboard; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayKeyboardActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayKeyboardActions instance)
        {
            if (m_Wrapper.m_GameplayKeyboardActionsCallbackInterface != null)
            {
                @MoveUp.started -= m_Wrapper.m_GameplayKeyboardActionsCallbackInterface.OnMoveUp;
                @MoveUp.performed -= m_Wrapper.m_GameplayKeyboardActionsCallbackInterface.OnMoveUp;
                @MoveUp.canceled -= m_Wrapper.m_GameplayKeyboardActionsCallbackInterface.OnMoveUp;
                @MoveLeft.started -= m_Wrapper.m_GameplayKeyboardActionsCallbackInterface.OnMoveLeft;
                @MoveLeft.performed -= m_Wrapper.m_GameplayKeyboardActionsCallbackInterface.OnMoveLeft;
                @MoveLeft.canceled -= m_Wrapper.m_GameplayKeyboardActionsCallbackInterface.OnMoveLeft;
                @MoveRight.started -= m_Wrapper.m_GameplayKeyboardActionsCallbackInterface.OnMoveRight;
                @MoveRight.performed -= m_Wrapper.m_GameplayKeyboardActionsCallbackInterface.OnMoveRight;
                @MoveRight.canceled -= m_Wrapper.m_GameplayKeyboardActionsCallbackInterface.OnMoveRight;
                @MoveDown.started -= m_Wrapper.m_GameplayKeyboardActionsCallbackInterface.OnMoveDown;
                @MoveDown.performed -= m_Wrapper.m_GameplayKeyboardActionsCallbackInterface.OnMoveDown;
                @MoveDown.canceled -= m_Wrapper.m_GameplayKeyboardActionsCallbackInterface.OnMoveDown;
            }
            m_Wrapper.m_GameplayKeyboardActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MoveUp.started += instance.OnMoveUp;
                @MoveUp.performed += instance.OnMoveUp;
                @MoveUp.canceled += instance.OnMoveUp;
                @MoveLeft.started += instance.OnMoveLeft;
                @MoveLeft.performed += instance.OnMoveLeft;
                @MoveLeft.canceled += instance.OnMoveLeft;
                @MoveRight.started += instance.OnMoveRight;
                @MoveRight.performed += instance.OnMoveRight;
                @MoveRight.canceled += instance.OnMoveRight;
                @MoveDown.started += instance.OnMoveDown;
                @MoveDown.performed += instance.OnMoveDown;
                @MoveDown.canceled += instance.OnMoveDown;
            }
        }
    }
    public GameplayKeyboardActions @GameplayKeyboard => new GameplayKeyboardActions(this);
    public interface IGameplayJoystickActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnRotate(InputAction.CallbackContext context);
    }
    public interface IGameplayKeyboardActions
    {
        void OnMoveUp(InputAction.CallbackContext context);
        void OnMoveLeft(InputAction.CallbackContext context);
        void OnMoveRight(InputAction.CallbackContext context);
        void OnMoveDown(InputAction.CallbackContext context);
    }
}
