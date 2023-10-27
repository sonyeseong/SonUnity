using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float jumpForce = 10f; // 점프 힘 설정
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // 스페이스 키 입력 감지
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    void Jump()
    {
        // 캐릭터를 위로 점프
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
    }
}
