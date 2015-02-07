using UnityEngine;
using System.Collections;

public class SoundWaveController : MonoBehaviour
{
    WaterController waterController;
    BackgroundMusicManager backgroundMusic;

    void Awake()
    {
        waterController = GameObject.Find("Water").GetComponent<WaterController>();
        backgroundMusic = GameObject.Find("BackgroundMusic").GetComponent<BackgroundMusicManager>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            gameObject.SetActive(false);
            //GameEventManager.TriggerWaterPickup();
            waterController.WaterPickup();
            backgroundMusic.ChangeMusic();
        }
    }
}
