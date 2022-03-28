using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private PlayerComponent playerComponent;
    private PlayerInput playerInput;
    [SerializeField]private float speed;
    [SerializeField]private float dashRange = 0.3f;
    private Vector2 direction;
    private bool areTwoKeysPressed;
    private enum Facing {UP, DOWN, LEFT, RIGHT};
    private Facing facingDir = Facing.DOWN;

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
        direction = playerInput.PlayerMovement.Movement.ReadValue<Vector2>();
        areTwoKeysPressed = direction.x != 0 && direction.y != 0;
        Move();
    }
    public void Move()
    {
        transform.Translate(direction * speed * Time.deltaTime);
        if (direction.x != 0 || direction.y != 0)
        {
            SetAnimatorMovement(direction);
        }
        else
        {
            playerComponent.animator.SetLayerWeight(1, 0);
        }
    }

    public void UseDash(InputAction.CallbackContext context)
    {
        if (context.performed)
            transform.Translate(direction.normalized * dashRange);
    }
    private void SetAnimatorMovement(Vector2 direction)
    {
        playerComponent.animator.SetLayerWeight(1, 1);
        playerComponent.animator.SetFloat("xDir", direction.x);
        playerComponent.animator.SetFloat("yDir", direction.y);
        playerComponent.animator.SetBool("twoDirKeysPressed", areTwoKeysPressed);
    }

}
