using UnityEngine;
using System.Collections;

public class SoundWaveController : MonoBehaviour
{
    public AudioSource pickupAudioSource;

    CameraController mainCamera;
    SoundPickupController soundPickupController;

    BackgroundMusicManager backgroundMusic;
    EarthController earthController;
    WaterController waterController;
    SandController sandController;

    void Awake()
    {
        mainCamera = GameObject.Find("MainCamera").GetComponent<CameraController>();
        soundPickupController = GameObject.Find("SoundPickups").GetComponent<SoundPickupController>();
        backgroundMusic = GameObject.Find("BackgroundMusic").GetComponent<BackgroundMusicManager>();

        // Grass state
        earthController = GameObject.Find("Grass").GetComponent<EarthController>();

        // Water state
        waterController = GameObject.Find("Water").GetComponent<WaterController>();

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
            //pickupAudioSource.Play();
            AudioSource.PlayClipAtPoint(pickupAudioSource.clip, Vector3.zero);
            soundPickupController.soundPickupState++;
            gameObject.SetActive(false);
            if (soundPickupController.soundPickupState == 1) // Grass state
            {
                backgroundMusic.ChangeMusic();
                earthController.FadeInSprites();
                mainCamera.ZoomSlowly(5.4f);
            }
            else if (soundPickupController.soundPickupState == 2) // Water state
            {
                backgroundMusic.ChangeMusic();
                waterController.WaterPickup();
                waterController.FadeInSprites();
                //woodController.FadeAndZoom();
                mainCamera.ZoomSlowly(5.8f);
            }
            else if (soundPickupController.soundPickupState == 3) // Sand state
            {
                backgroundMusic.ChangeMusic();
                sandController.FadeInSprites();
                mainCamera.ZoomSlowly(6.20f);
            }
            
            

        }
    }
}
