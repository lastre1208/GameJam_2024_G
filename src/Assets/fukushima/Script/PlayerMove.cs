using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 5f;
    public bool Onlife = true;
    void Update()
    {
        if (Onlife)
        {
            // A�L�[�AD�L�[�A�����L�[�A�E���L�[�ł̈ړ����͂��擾
            float moveInput = Input.GetAxisRaw("Horizontal");

            // �����L�[�A�E���L�[�̓��͂�ǉ�
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                moveInput = -1f;
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                moveInput = 1f;
            }

            // �v���C���[�����E�Ɉړ�������
            transform.Translate(Vector3.right * moveInput * moveSpeed * Time.deltaTime);
        }
    }
}
