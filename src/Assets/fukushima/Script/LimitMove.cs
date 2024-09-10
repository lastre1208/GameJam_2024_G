using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LimitMove : MonoBehaviour
{
    [SerializeField] float Limitmove;

 
    private void Update()
    {
        if (transform.position.x > Limitmove || transform.position.x < Limitmove * -1)
        {
            Vector3 currentpos=transform.position;
          
            currentpos.x=Mathf.Clamp(currentpos.x, -Limitmove, Limitmove);
            transform.position=currentpos;
        }
    }
}
