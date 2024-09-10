using UnityEngine;

public class PlayerParameter : MonoBehaviour
{
    private bool WallHitFlag { get; set; }

    [SerializeField]
    float landingSpeed,maxSpeed, minSpeed;
    [SerializeField]
    float addSpeed, decreaseSpeed;

    [SerializeField]
    float hitPoint,maxPoint, minPoint;
    [SerializeField]
    float addHitPoint, decreaseHitPoint;

    public float GetLandingSpeed() { return landingSpeed; }
    public float GetHitPoint () { return hitPoint; }
    public void SetLandingSpeed(float value)
    {
        if (value <= minSpeed || value >= maxSpeed)
            return;
        landingSpeed = value;
    }

    public void SetHitPoint(float value)
    {
        if (value <= minPoint || value >= maxPoint)
            return;
        hitPoint = value;
    }

    private void Start()
    {
        WallHitFlag = false;
    }
    private void Update()
    {
        if (WallHitFlag)
        {
            SetLandingSpeed(landingSpeed - decreaseSpeed);
            SetHitPoint(hitPoint - decreaseHitPoint);
        }
        else
        {
            SetLandingSpeed(landingSpeed + addSpeed);
            SetHitPoint(hitPoint + addHitPoint);
        }
    }
}
