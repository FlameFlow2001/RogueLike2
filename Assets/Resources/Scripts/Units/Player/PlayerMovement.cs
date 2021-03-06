using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private PlayerComponent playerComponent;
    private PlayerInput playerInput;
    [SerializeField]private float speed;
    [HideInInspector] public Vector2 direction;
    private bool moveButtonIsHeld;
    private bool areTwoKeysPressed;
    private void Start()
    {
        playerComponent = gameObject.GetComponent<PlayerComponent>();
    }
    private void Awake()
    {
        playerInput = new PlayerInput();
    }

    private void OnEnable()
    {
        playerInput.Enable();
    }

    private void OnDisable()
    {
        playerInput.Disable();
    }
    void Update()
    {
        if (moveButtonIsHeld)
        {
            direction = playerInput.PlayerMovement.Movement.ReadValue<Vector2>();
            areTwoKeysPressed = direction.x != 0 && direction.y != 0;
            Move();
        }
        else
            playerComponent.animator.SetLayerWeight(1, 0);
    }

    public void SetStateMoveButton(InputAction.CallbackContext context)
    {
        if (context.performed)
            moveButtonIsHeld = true;
        if (context.canceled)
            moveButtonIsHeld = false;
    }
    public void Move()
    {
        transform.Translate(direction * speed * Time.deltaTime);
        if (direction.x != 0 || direction.y != 0)
            SetAnimatorMovement(direction);
    }
    private void SetAnimatorMovement(Vector2 direction)
    {
        playerComponent.animator.SetLayerWeight(1, 1);
        playerComponent.animator.SetFloat("xDir", direction.x);
        playerComponent.animator.SetFloat("yDir", direction.y);
        playerComponent.animator.SetBool("twoDirKeysPressed", areTwoKeysPressed);
    }

}