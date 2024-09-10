using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDistanceCounter : MonoBehaviour
{
    [SerializeField]
    float DistanseLimit;
    [SerializeField]
    PlayerParameter parameter;
    float landingDistanse = 0;

    bool IsCrear = false;


    bool GetCrear() => IsCrear;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        landingDistanse += parameter.GetLandingSpeed();
        if(DistanseLimit <= landingDistanse)
        {
            Debug.Log("Crear!");
            IsCrear = true;
        }
    }
}
