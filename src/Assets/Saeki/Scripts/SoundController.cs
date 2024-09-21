using UnityEngine;

public class SoundController : MonoBehaviour
{
    [SerializeField]
    AudioSource BGM, Shout,Death, Clear;
    [SerializeField]
    AudioClip[] Shoutclip,Deathclip,Clearclip;
    [SerializeField]
    PlayerParameter playerParameter;
    [SerializeField]
    MoveDistanceCounter moveDistanceCounter;
    bool Shoutflag,DeathFlag,ClearFlag;

    void Start()
    {
        Shoutflag = false;
        DeathFlag = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(playerParameter.Onlife == false)
        {
            BGM.mute = true;
            DeathOneShot();
        }

        if (playerParameter.GetWallHitFlag())
            ShoutOneShot();
        else
        {
            Shoutflag = false;
            Shout.Stop();
        }
    }

    void ShoutOneShot()
    {
        if (Shoutflag || DeathFlag)
            return;
        Shoutflag = true;
        Shout.clip = RandomPicUp(Shoutclip);
        Shout.PlayOneShot(Shout.clip);
    }
    void DeathOneShot()
    {
        if (DeathFlag)
            return;
        DeathFlag = true;
        Death.clip = RandomPicUp(Deathclip);
        Death.PlayOneShot(Death.clip);
    }

    public void ClearOneShot()
    {
        if (ClearFlag)
            return;
        ClearFlag = true;
        Clear.clip = RandomPicUp(Clearclip);
        Clear.PlayOneShot(Clear.clip);
    }

    AudioClip RandomPicUp(AudioClip[] clips)
    {
        return clips[Random.Range(0,clips.Length)];
    }
}
