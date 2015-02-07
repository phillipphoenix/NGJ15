using UnityEngine;
using System.Collections;

public class SoundWaveController : MonoBehaviour
{
    WaterController waterController;
    BackgroundMusicManager backgroundMusic;
    EarthController earthController;

    void Awake()
    {
        waterController = GameObject.Find("Water").GetComponent<WaterController>();
        backgroundMusic = GameObject.Find("BackgroundMusic").GetComponent<BackgroundMusicManager>();
        earthController = GameObject.Find("Earth").GetComponent<EarthController>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            gameObject.SetActive(false);
            //GameEventManager.TriggerWaterPickup();
            //waterController.WaterPickup();
            backgroundMusic.ChangeMusic();
            earthController.FadeInSprites();
        }
    }
}
