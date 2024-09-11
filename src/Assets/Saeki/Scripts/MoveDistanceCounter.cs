using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDistanceCounter : MonoBehaviour
{
    [SerializeField]
    float DistanseLimit;
    [SerializeField]
    PlayerParameter parameter;
    [SerializeField]
    GameOverFlag gameOverFlag;

    [SerializeField]
    GameObject backImageObject;
    float landingDistanse = 0;

    bool IsCrear = false;


    public bool GetCrear() => IsCrear;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOverFlag.GetGameOver())
            return;

        landingDistanse += parameter.GetLandingSpeed();
        if(DistanseLimit <= landingDistanse)
        {
            Debug.Log("Crear!");
            IsCrear = true;
        }
        Vector3 backImagevector = backImageObject.transform.position;

        backImagevector.y = backImagevector.y < 60f ? landingDistanse / 7000f : 60f;
       
        backImageObject.transform.position = backImagevector;
    }
}
