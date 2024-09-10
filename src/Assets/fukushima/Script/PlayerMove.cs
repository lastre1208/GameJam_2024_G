using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 5f;
    public bool Onlife = true;
    void Update()
    {
        if (Onlife)
        {
            // Aキー、Dキー、左矢印キー、右矢印キーでの移動入力を取得
            float moveInput = Input.GetAxisRaw("Horizontal");

            // 左矢印キー、右矢印キーの入力を追加
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                moveInput = -1f;
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                moveInput = 1f;
            }

            // プレイヤーを左右に移動させる
            transform.Translate(Vector3.right * moveInput * moveSpeed * Time.deltaTime);
        }
    }
}
