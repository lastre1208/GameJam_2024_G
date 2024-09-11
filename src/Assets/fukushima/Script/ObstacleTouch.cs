using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObstacleTouch : MonoBehaviour
{
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
