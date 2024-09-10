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
            // A�L�[�AD�L�[�A�����L�[�A�E���L�[�ł̈ړ����͂��擾
            float moveInput = Input.GetAxisRaw("Horizontal");

            // �����L�[�A�E���L�[�̓��͂�ǉ�
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

            // �v���C���[�����E�Ɉړ�������
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
