using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OceanMove : MonoBehaviour
{
    [SerializeField]
    Animator moveAnimator;

    [SerializeField]
    MoveDistanceCounter counter;

    [SerializeField]
    GameOverFlag gameOverFlag;

    [SerializeField]
    GameObject[] ClearObjects;
    [SerializeField]
    GameObject offActiveObject;

    public void AnimatorMove()
    {
        moveAnimator.SetBool("ClearBool", true);
    }

    public void AnimatorStop()
    {
        moveAnimator.SetBool("ClearBool", false);
        moveAnimator.StopPlayback();
    }
    public void ClearFlag()
    {
        foreach (var objects in ClearObjects)
        {
            objects.SetActive(true);
        }
        offActiveObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (counter.GetCrear()) AnimatorMove();

        if(gameOverFlag.GetGameOver()) { AnimatorStop(); }
    }
}
