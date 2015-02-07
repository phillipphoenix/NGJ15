using UnityEngine;
using System.Collections;

public class WaterController : MonoBehaviour
{
    /*void OnEnable()
    {
        GameEventManager.WaterPickup += WaterPickup;
    }*/
    Animator anim;

    void Awake()
    {
        anim = GetComponent<Animator>();
    }

    public void WaterPickup()
    {
        anim.SetTrigger("FadeIn");
    }
}
