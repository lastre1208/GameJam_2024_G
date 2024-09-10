using System;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float moveLimit = 8f;
   public  Rigidbody rb;
    [SerializeField] PlayerParameter parameter;
    void Update()
    {
        if (parameter.Onlife)
        {
            // Aキー、Dキー、左矢印キー、右矢印キーでの移動入力を取得
            float moveInput = Input.GetAxisRaw("Horizontal");

            // 左矢印キー、右矢印キーの入力を追加
            if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
            {
                moveInput = -1f;
            }
            else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
            {
                moveInput = 1f;
            }
            else
            {
                rb.velocity = Vector3.zero;
            }

            // プレイヤーを左右に移動させる
            //transform.Translate(Vector3.right * moveInput * moveSpeed * Time.deltaTime);
            rb.AddForce(new Vector3(moveInput*moveSpeed,0,0));
            if (moveLimit< Math.Abs(rb.velocity.x))
            {
                if(rb.velocity.x > 0)
                {
                    rb.velocity = new(moveLimit,0,0);
                }
                else
                {                   
                    rb.velocity = new(-moveLimit, 0, 0);     
                }
            }
        }
    }
}
