using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ObstcaleCreater : MonoBehaviour
{
    [SerializeField]
    ObstcleMove obstcleScript;

    [SerializeField]
    GameObject[] obstcalesPrehab;

    [SerializeField]
    int CreateDistanseRange;

    [SerializeField]
    float CreateTimeInterval;

    float timeCount = 0;

    int BeforeValue = 0;
    // Update is called once per frame
    void Update()
    {
        timeCount += Time.deltaTime;
        if(timeCount > CreateTimeInterval)
        {
            timeCount = 0f;
            Createobstcale(obstcalesPrehab);
        }
    }

    int GetRandomNum(int range)
    {
        int random = Random.Range(-range,range);
        return random == BeforeValue ? GetRandomNum(range) : random;
    }




    void Createobstcale(GameObject[] prehabs)
    {
        if (prehabs == null || prehabs.Length == 0)
            return;

        int RandomNum = Random.Range(0, prehabs.Length);

        Vector3 CreatePos = transform.position;
        CreatePos.x = (float)GetRandomNum(CreateDistanseRange);

        GameObject gameObject = GameObject.Instantiate(prehabs[RandomNum],
           CreatePos, Quaternion.identity);

        obstcleScript.AddObstacle(gameObject);
    }


}
