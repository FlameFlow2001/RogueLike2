using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float dashRange = 3;
    private Vector2 direction;
    private Animator animator;
    private bool areTwoKeysPressed;
    private enum Facing {UP, DOWN, LEFT, RIGHT};
    private Facing facingDir = Facing.DOWN;
    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        TakeInput();
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
            animator.SetLayerWeight(1, 0);
        }
    }

    public void TakeInput()
    {
        direction = Vector2.zero;

        if (Input.GetKey(KeyCode.W))
        {
            direction += Vector2.up;
            facingDir = Facing.UP;
        }

        if (Input.GetKey(KeyCode.A))
        {
            direction += Vector2.left;
            facingDir = Facing.LEFT;
        }

        if (Input.GetKey(KeyCode.S))
        {
            direction += Vector2.down;
            facingDir = Facing.DOWN;
        }

        if (Input.GetKey(KeyCode.D))
        {
            direction += Vector2.right;
            facingDir = Facing.RIGHT;

        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            Vector2 targetPos = Vector2.zero;

            switch (facingDir)
            {
                case Facing.UP:
                    targetPos.y = 1;
                    break;

                case Facing.DOWN:
                    targetPos.y = -1;
                    break;

                case Facing.LEFT:
                    targetPos.x = -1;
                    break;

                case Facing.RIGHT:
                    targetPos.x = 1;
                    break;
            }

            transform.Translate(targetPos * dashRange);
        }
        areTwoKeysPressed = direction.x != 0 && direction.y != 0;
    }

    private void SetAnimatorMovement(Vector2 direction)
    {
        animator.SetLayerWeight(1, 1);
        animator.SetFloat("xDir", direction.x);
        animator.SetFloat("yDir", direction.y);
        animator.SetBool("twoDirKeysPressed", areTwoKeysPressed);
    }
}
