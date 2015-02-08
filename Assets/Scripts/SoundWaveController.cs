using UnityEngine;
using System.Collections;

public class SoundWaveController : MonoBehaviour
{
    public AudioSource pickupAudioSource;

    SoundPickupController soundPickupController;

    BackgroundMusicManager backgroundMusic;
    EarthController earthController;
    WaterController waterController;
    PieceOfWoodController woodController;
    SandController sandController;

    void Awake()
    {
        soundPickupController = GameObject.Find("SoundPickups").GetComponent<SoundPickupController>();
        backgroundMusic = GameObject.Find("BackgroundMusic").GetComponent<BackgroundMusicManager>();

        // Grass state
        earthController = GameObject.Find("Grass").GetComponent<EarthController>();

        // Water state
        waterController = GameObject.Find("Water").GetComponent<WaterController>();
        woodController = GameObject.Find("PieceOfWood").GetComponent<PieceOfWoodController>();

        // Sand state
        sandController = GameObject.Find("Sand").GetComponent<SandController>();

        if (sandController == null)
        {
            Debug.Log("SandController == null...");
        }

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            pickupAudioSource.Play();
            soundPickupController.soundPickupState++;
            gameObject.SetActive(false);
            if (soundPickupController.soundPickupState == 1) // Grass state
            {
                backgroundMusic.ChangeMusic();
                earthController.FadeInSprites();
            }
            else if (soundPickupController.soundPickupState == 2) // Water state
            {
                backgroundMusic.ChangeMusic();
                waterController.WaterPickup();
                waterController.FadeInSprites();
                //woodController.FadeAndZoom();
            }
            else if (soundPickupController.soundPickupState == 3) // Sand state
            {
                backgroundMusic.ChangeMusic();
                sandController.FadeInSprites();
            }
            
            

        }
    }
}
