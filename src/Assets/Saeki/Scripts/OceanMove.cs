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
    SoundController soundController;
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
        if (gameOverFlag.GetGameOver())
            return;
        foreach (var objects in ClearObjects)
        {
            objects.SetActive(true);
        }
        offActiveObject.SetActive(false);
        soundController.ClearOneShot();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (counter.GetCrear()) AnimatorMove();

        if(gameOverFlag.GetGameOver()) { AnimatorStop(); }
    }
}
