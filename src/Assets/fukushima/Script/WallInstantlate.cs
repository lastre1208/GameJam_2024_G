using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallIGenerate : MonoBehaviour
{
    [SerializeField] float GenerateTime;
    private float TimeCount;
    [SerializeField] float LeftLimit;
    [SerializeField] float RightLimit;
    [SerializeField] Transform GeneratePoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TimeCount += Time.deltaTime;
        if(GenerateTime <= TimeCount)
        {
            TimeCount = 0;
        }
    }
}
