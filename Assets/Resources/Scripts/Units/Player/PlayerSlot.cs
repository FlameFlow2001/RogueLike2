using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerSlot : MonoBehaviour
{
    private PlayerComponent playerComponent;
    public BasicWeaponScript weapon;
    public GameObject firstSkill;
    public GameObject secondSkill;
    public GameObject thirdSkill;
    public GameObject ultimate;
    private bool attackButtonIsHeld;
    private void Awake()
    {
        playerComponent = gameObject.GetComponent<PlayerComponent>();
    }
    private void Update()
    {
        if (attackButtonIsHeld)
            weapon.TryToAttack(playerComponent.transform.position, UsingDirectionCalculating());
    }
    protected Vector2 UsingDirectionCalculating()
    {
        Vector2 mousePos2D = Input.mousePosition;
        var screenToCameraDistance = Camera.main.nearClipPlane;
        var mousePosNearClipPlane = new Vector3(mousePos2D.x, mousePos2D.y, screenToCameraDistance);
        Vector2 worldPointPos = Camera.main.ScreenToWorldPoint(mousePosNearClipPlane);
        Vector2 playerPos = playerComponent.transform.position;
        Vector2 calculatedShootingDirection = (worldPointPos - playerPos).normalized;
        return calculatedShootingDirection;
    }

    public void UseWeapon(InputAction.CallbackContext context)
    {
        if (context.performed)
            attackButtonIsHeld = true;
        if (context.canceled)
            attackButtonIsHeld = false;
            
    }

    public void UseFirstSkill(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            firstSkill.GetComponent<ActiveSkill>().TryToUseSkill();
        }
    }

    public void UseSecondSkill(InputAction.CallbackContext context)
    {
        if (context.performed)
            secondSkill.GetComponent<ActiveSkill>().TryToUseSkill();
    }

    public void UseThirdSkill(InputAction.CallbackContext context)
    {
        if (context.performed)
            thirdSkill.GetComponent<ActiveSkill>().TryToUseSkill();
    }

    public void UseUltimate(InputAction.CallbackContext context)
    {
        if (context.performed)
            ultimate.GetComponent<ActiveSkill>().TryToUseSkill();
    }
}
