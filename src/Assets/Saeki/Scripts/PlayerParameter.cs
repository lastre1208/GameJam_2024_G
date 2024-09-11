using UnityEngine;

public class PlayerParameter : MonoBehaviour
{
    private bool WallHitFlag;
    public bool Onlife = true;
    [SerializeField]
    float landingSpeed,maxSpeed, minSpeed;
    [SerializeField]
    float addSpeed, decreaseSpeed;

    [SerializeField]
    float hitPoint,maxPoint, minPoint;
    [SerializeField]
    float addHitPoint, decreaseHitPoint;
    [Space]
    [SerializeField]
    AgentAnimetion agentAnimetion;
    [SerializeField]
    MoveDistanceCounter moveDistanceCounter;

    public float GetLandingSpeed() => landingSpeed;
    public float GetHitPoint() => hitPoint;
    public bool GetWallHitFlag() => WallHitFlag;
    public void SetLandingSpeed(float value, bool mode)
    {

        if (mode)
        {
            if ((landingSpeed > value && value <= minSpeed) || value >= maxSpeed)
                return;
        }
        else
        {
            if((landingSpeed > value && value <= minSpeed) || value >= maxSpeed / 2)
                return;
        }
        landingSpeed = value;
    }

    public void SetHitPoint(float value)
    {
        if (value < minPoint || value >= maxPoint)
            return;
        hitPoint = value;
    }

    public void SetFlag(bool boolan, float horizontal)
    {
        WallHitFlag = boolan;

        if (boolan == false) 
            agentAnimetion.WallHitAnim(0);
        else if (horizontal < 0)
            agentAnimetion.WallHitAnim(-1);
        else
            agentAnimetion.WallHitAnim(1);
    }
    private void Start()
    {
        WallHitFlag = false;
    }
    private void Update()
    {
        if (Onlife)
            fluctuation();

        if (GetHitPoint() < 0)
            Onlife = false;
    }

    private void fluctuation()
    {
        if (WallHitFlag)
        {
            SetLandingSpeed(landingSpeed - decreaseSpeed, true);
            SetHitPoint(hitPoint - decreaseHitPoint);
        }
        else
        {
            
            if (moveDistanceCounter.GetNowDistanse() > moveDistanceCounter.GettargetDistanse() / 4f)
                SetLandingSpeed(landingSpeed + addSpeed,true);
            else
                SetLandingSpeed(landingSpeed + addSpeed, false);
            SetHitPoint(hitPoint + addHitPoint);
        }
    }
}
