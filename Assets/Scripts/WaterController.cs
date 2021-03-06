﻿using UnityEngine;
using System.Collections;

public class WaterController : MonoBehaviour
{
    public SpriteRenderer[] waterSprites;
    private float alpha = 0f;

    BackgroundMusicManager backgroundMusic;
    Animator anim;

    void Awake()
    {
        anim = GetComponent<Animator>();
        foreach (var sprite in waterSprites)
        {
            sprite.color = new Color(sprite.color.r, sprite.color.g, sprite.color.b, 0);
        }
    }

    public void WaterPickup()
    {
        anim.SetTrigger("FadeIn");
    }

    public void FadeInSprites()
    {
        StartCoroutine(FadeIn());
    }

    IEnumerator FadeIn()
    {
        while (alpha < 1f)
        {
            alpha += 0.1f;
            foreach (var sprite in waterSprites)
            {
                sprite.color = new Color(sprite.color.r, sprite.color.g, sprite.color.b, alpha);
            }
            yield return new WaitForSeconds(0.2f);
        }
    }
}
