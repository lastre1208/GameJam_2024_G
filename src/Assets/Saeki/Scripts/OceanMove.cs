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
    GameObject ClearObject, offActiveObject;

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
        ClearObject.SetActive(true);
        offActiveObject.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (counter.GetCrear()) AnimatorMove();

        if(gameOverFlag.GetGameOver()) { AnimatorStop(); }
    }
}
