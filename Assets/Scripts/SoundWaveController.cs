using UnityEngine;
using System.Collections;

public class SoundWaveController : MonoBehaviour
{
    public WaterController waterController;

    void Awake()
    {
        waterController = GameObject.Find("Water").GetComponent<WaterController>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            gameObject.SetActive(false);
            //GameEventManager.TriggerWaterPickup();
            waterController.WaterPickup();
        }
    }
}
