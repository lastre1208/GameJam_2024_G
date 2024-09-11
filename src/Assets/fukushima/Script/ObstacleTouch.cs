using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObstacleTouch : MonoBehaviour
{

    private void Start()
    {  
        //playerMove = GetComponent<PlayerMove>();
    }
    // Start is called before the first frame update
    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
                Debug.Log("Hit!");
          PlayerParameter parameter = other.GetComponent<PlayerParameter>();
            parameter.Onlife = false;
            parameter.SetFloorFlag();
        }
    }
}
