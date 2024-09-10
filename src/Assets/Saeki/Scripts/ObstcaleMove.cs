using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstcleMove : MonoBehaviour
{
    [SerializeField]
    PlayerParameter playerParameter;
   
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
        if(playerParameter.Onlife)
            MovePos();
    }

    //List内のオブジェクトの移動
    void MovePos()
    {
        foreach (var obstacle in obstacles)
        {
            obstacle.transform.Translate(Vector3.up * Time.deltaTime * playerParameter.GetLandingSpeed());
        }
    }
}
