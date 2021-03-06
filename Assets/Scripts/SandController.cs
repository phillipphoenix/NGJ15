﻿using UnityEngine;
using System.Collections;

public class SandController : MonoBehaviour {

    public SpriteRenderer[] sandSprites;
    private float alpha = 0f;

    void Awake()
    {
        foreach (var sprite in sandSprites)
        {
            sprite.color = new Color(sprite.color.r, sprite.color.g, sprite.color.b, 0);
        }
    }

    void Update()
    {

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
            foreach (var sprite in sandSprites)
            {
                sprite.color = new Color(sprite.color.r, sprite.color.g, sprite.color.b, alpha);
            }
            yield return new WaitForSeconds(0.2f);
        }
    }

}
