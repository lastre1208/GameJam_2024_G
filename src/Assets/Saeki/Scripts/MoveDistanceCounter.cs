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

    public float GetNowDistanse() => landingDistanse;
    public float GettargetDistanse() => DistanseLimit;
    public bool GetCrear() => IsCrear;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (gameOverFlag.GetGameOver())
            return;

        landingDistanse += parameter.GetLandingSpeed();
        Debug.Log(landingDistanse);
        if (DistanseLimit <= landingDistanse)
        {
            landingDistanse = DistanseLimit;
            IsCrear = true;
        }
        Vector3 backImagevector = backImageObject.transform.position;

        backImagevector.y = backImagevector.y < 45f ? landingDistanse / 500f : 45f;
       
        backImageObject.transform.position = backImagevector;
    }
}
