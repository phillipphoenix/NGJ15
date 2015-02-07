using UnityEngine;
using System.Collections;

public class EarthController : MonoBehaviour {

    public SpriteRenderer[] earthSprites;
    public EdgeCollider2D bridgeCollider;
    private float alpha = 0f;

    void Awake()
    {
        foreach (var sprite in earthSprites)
        {
            sprite.color = new Color(sprite.color.r, sprite.color.g, sprite.color.b, 0);
        }
    }

    void Update()
    {

    }

    public void FadeInSprites()
    {
        bridgeCollider.enabled = false;
        StartCoroutine(FadeIn());

    }

    IEnumerator FadeIn()
    {
        while (alpha < 1f)
        {
            alpha += 0.1f;
            foreach(var sprite in earthSprites) {
                sprite.color = new Color(sprite.color.r, sprite.color.g, sprite.color.b,alpha);
            }
            yield return new WaitForSeconds(0.2f);
        }
    }

}
