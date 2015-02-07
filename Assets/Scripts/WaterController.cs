using UnityEngine;
using System.Collections;

public class WaterController : MonoBehaviour
{
    BackgroundMusicManager backgroundMusic;
    Animator anim;

    void Awake()
    {
        backgroundMusic = GameObject.Find("BackgroundMusic").GetComponent<BackgroundMusicManager>();
        anim = GetComponent<Animator>();
    }

    public void WaterPickup()
    {
        anim.SetTrigger("FadeIn");
        backgroundMusic.ChangeMusic();
    }
}
