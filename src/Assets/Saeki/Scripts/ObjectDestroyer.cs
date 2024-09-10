using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroyer : MonoBehaviour
{
    [SerializeField] ObstcleMove obstcleScript;
    private void OnTriggerEnter(Collider other)
    {
        obstcleScript.RemoveObstacle(other.gameObject);
        Destroy(other.gameObject);
    }
}
