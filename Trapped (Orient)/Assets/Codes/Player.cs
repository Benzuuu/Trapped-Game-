// GENERATED AUTOMATICALLY FROM 'Assets/Codes/Player.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Player : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Player()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Player"",
    ""maps"": [
        {
            ""name"": ""General"",
            ""id"": ""b3dccb42-7d40-4e8e-a824-f9985127b55a"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""999f65cb-4c2d-49c4-9ac0-8900837d5172"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""6b26a29f-cf33-48ff-a8a1-5356db99c467"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""ToggleInventory"",
                    ""type"": ""Button"",
                    ""id"": ""d333556b-176f-484c-a2d8-096456023c48"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""3844ea4e-817a-46cf-b2ef-ecdc309a3793"",
                    ""path"": ""2DVector"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""d6ce137a-3284-4e30-ac44-5b6e829cceb7"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""6cc4bf95-29bf-4432-8903-57b2b6acb0a1"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""0e469e8c-1baf-493e-9c02-7b603d590e2d"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""2cd62576-3638-479b-a4fa-3f2320abef44"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""8d5914f6-ea8d-44b5-b058-47408b5a0147"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f8b9cc39-6ce5-4099-933a-321efb2c20b1"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""ToggleInventory"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Inventory"",
            ""id"": ""d50c9a48-0ed3-463e-aae8-577cb484edb6"",
            ""actions"": [
                {
                    ""name"": ""Return"",
                    ""type"": ""Button"",
                    ""id"": ""7c065380-4e1c-4ae9-9132-9ef6b8737208"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Select Up"",
                    ""type"": ""Button"",
                    ""id"": ""578dbd81-4b1d-44c9-85eb-c7e495a76ce6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Select Down"",
                    ""type"": ""Button"",
                    ""id"": ""515d1163-38ff-481f-a100-5f69a3eab608"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a410ed48-e20a-4498-b802-64007ee08884"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Return"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9bb6b322-c61b-4143-ad83-492359c89d32"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Select Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2d07cd89-7581-4c09-a488-bb49d30fc6df"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Select Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // General
        m_General = asset.FindActionMap("General", throwIfNotFound: true);
        m_General_Movement = m_General.FindAction("Movement", throwIfNotFound: true);
        m_General_Interact = m_General.FindAction("Interact", throwIfNotFound: true);
        m_General_ToggleInventory = m_General.FindAction("ToggleInventory", throwIfNotFound: true);
        // Inventory
        m_Inventory = asset.FindActionMap("Inventory", throwIfNotFound: true);
        m_Inventory_Return = m_Inventory.FindAction("Return", throwIfNotFound: true);
        m_Inventory_SelectUp = m_Inventory.FindAction("Select Up", throwIfNotFound: true);
        m_Inventory_SelectDown = m_Inventory.FindAction("Select Down", throwIfNotFound: true);
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

    // General
    private readonly InputActionMap m_General;
    private IGeneralActions m_GeneralActionsCallbackInterface;
    private readonly InputAction m_General_Movement;
    private readonly InputAction m_General_Interact;
    private readonly InputAction m_General_ToggleInventory;
    public struct GeneralActions
    {
        private @Player m_Wrapper;
        public GeneralActions(@Player wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_General_Movement;
        public InputAction @Interact => m_Wrapper.m_General_Interact;
        public InputAction @ToggleInventory => m_Wrapper.m_General_ToggleInventory;
        public InputActionMap Get() { return m_Wrapper.m_General; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GeneralActions set) { return set.Get(); }
        public void SetCallbacks(IGeneralActions instance)
        {
            if (m_Wrapper.m_GeneralActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_GeneralActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_GeneralActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_GeneralActionsCallbackInterface.OnMovement;
                @Interact.started -= m_Wrapper.m_GeneralActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_GeneralActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_GeneralActionsCallbackInterface.OnInteract;
                @ToggleInventory.started -= m_Wrapper.m_GeneralActionsCallbackInterface.OnToggleInventory;
                @ToggleInventory.performed -= m_Wrapper.m_GeneralActionsCallbackInterface.OnToggleInventory;
                @ToggleInventory.canceled -= m_Wrapper.m_GeneralActionsCallbackInterface.OnToggleInventory;
            }
            m_Wrapper.m_GeneralActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @ToggleInventory.started += instance.OnToggleInventory;
                @ToggleInventory.performed += instance.OnToggleInventory;
                @ToggleInventory.canceled += instance.OnToggleInventory;
            }
        }
    }
    public GeneralActions @General => new GeneralActions(this);

    // Inventory
    private readonly InputActionMap m_Inventory;
    private IInventoryActions m_InventoryActionsCallbackInterface;
    private readonly InputAction m_Inventory_Return;
    private readonly InputAction m_Inventory_SelectUp;
    private readonly InputAction m_Inventory_SelectDown;
    public struct InventoryActions
    {
        private @Player m_Wrapper;
        public InventoryActions(@Player wrapper) { m_Wrapper = wrapper; }
        public InputAction @Return => m_Wrapper.m_Inventory_Return;
        public InputAction @SelectUp => m_Wrapper.m_Inventory_SelectUp;
        public InputAction @SelectDown => m_Wrapper.m_Inventory_SelectDown;
        public InputActionMap Get() { return m_Wrapper.m_Inventory; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InventoryActions set) { return set.Get(); }
        public void SetCallbacks(IInventoryActions instance)
        {
            if (m_Wrapper.m_InventoryActionsCallbackInterface != null)
            {
                @Return.started -= m_Wrapper.m_InventoryActionsCallbackInterface.OnReturn;
                @Return.performed -= m_Wrapper.m_InventoryActionsCallbackInterface.OnReturn;
                @Return.canceled -= m_Wrapper.m_InventoryActionsCallbackInterface.OnReturn;
                @SelectUp.started -= m_Wrapper.m_InventoryActionsCallbackInterface.OnSelectUp;
                @SelectUp.performed -= m_Wrapper.m_InventoryActionsCallbackInterface.OnSelectUp;
                @SelectUp.canceled -= m_Wrapper.m_InventoryActionsCallbackInterface.OnSelectUp;
                @SelectDown.started -= m_Wrapper.m_InventoryActionsCallbackInterface.OnSelectDown;
                @SelectDown.performed -= m_Wrapper.m_InventoryActionsCallbackInterface.OnSelectDown;
                @SelectDown.canceled -= m_Wrapper.m_InventoryActionsCallbackInterface.OnSelectDown;
            }
            m_Wrapper.m_InventoryActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Return.started += instance.OnReturn;
                @Return.performed += instance.OnReturn;
                @Return.canceled += instance.OnReturn;
                @SelectUp.started += instance.OnSelectUp;
                @SelectUp.performed += instance.OnSelectUp;
                @SelectUp.canceled += instance.OnSelectUp;
                @SelectDown.started += instance.OnSelectDown;
                @SelectDown.performed += instance.OnSelectDown;
                @SelectDown.canceled += instance.OnSelectDown;
            }
        }
    }
    public InventoryActions @Inventory => new InventoryActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    public interface IGeneralActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnToggleInventory(InputAction.CallbackContext context);
    }
    public interface IInventoryActions
    {
        void OnReturn(InputAction.CallbackContext context);
        void OnSelectUp(InputAction.CallbackContext context);
        void OnSelectDown(InputAction.CallbackContext context);
    }
}
