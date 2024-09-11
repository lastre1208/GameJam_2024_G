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

    public void AddObstacle(GameObject parentObject)
    {
        int childCount = parentObject.transform.childCount;

        for (int i = 0; i < childCount; i++)
        {
            GameObject childObject = parentObject.transform.GetChild(i).gameObject;
            obstacles.Add(childObject);      
        }
        parentObject.transform.parent = null;
        //parentObject.SetActive(false);
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
