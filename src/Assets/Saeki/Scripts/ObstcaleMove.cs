using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstcleMove : MonoBehaviour
{
    [SerializeField]
    float UpMoveSpeed = 3f;
    [SerializeField]
    PlayerMove playerscript;
    List<GameObject> obstacles = new List<GameObject>();

    public void AddObstacle(GameObject remove)
    {
        obstacles.Add(remove);
    }
    public void RemoveObstacle(GameObject remove)
    {
        obstacles.Remove(remove);
    }

    // Update is called once per frame
    void Update()
    {
        if(playerscript.Onlife)
            MovePos();
    }

    //List���̃I�u�W�F�N�g�̈ړ�
    void MovePos()
    {
        foreach (var obstacle in obstacles)
        {
            obstacle.transform.Translate(Vector3.up * Time.deltaTime * UpMoveSpeed);
        }
    }
}
