using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float time;
    bool isInGround;
    Animator animator;
    [SerializeField, Range(0, 10)] float speed;
    [SerializeField] float jumpPower;
    Rigidbody2D rigidBody;
    float horizontalDelta;
    [SerializeField] Transform[] checkPoints;
    [SerializeField] LayerMask mapLayerMask;
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        horizontalDelta = 0;
        isInGround = Physics2D.OverlapArea(checkPoints[0].position, checkPoints[1].position, mapLayerMask);
        if (isInGround)
        {
            if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
            {
                Jump();
            }
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            horizontalDelta = Input.GetAxisRaw("Horizontal");
        }
        if (horizontalDelta == 0)
        {
            time += Time.deltaTime;
            if (time >= 0.25f)
            {
                if (!animator.GetCurrentAnimatorStateInfo(0).IsName("Dung"))
                {
                    animator.SetBool("isIdle", true);
                }
                time = 0;
            }
        }
    }
    void Jump()
    {
        animator.SetBool("isJump", true);
        rigidBody.velocity = new Vector3(0, jumpPower, 0);
    }
    private void FixedUpdate()
    {
        if (horizontalDelta != 0)
        {
            if (isInGround)
            {
                if (!animator.GetCurrentAnimatorStateInfo(0).IsName("Chay"))
                {
                    animator.SetBool("isRun", true);
                }
            }
            if (horizontalDelta < 0)
            {
                transform.localScale = new Vector3(-0.5f, 0.5f, 0.5f);
            }
            else
            {
                transform.localScale = Vector3.one * 0.5f;
            }
            rigidBody.velocity = new Vector2(horizontalDelta * speed, rigidBody.velocity.y);
        }
    }

}
