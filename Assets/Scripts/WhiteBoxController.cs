using UnityEngine;
using System.Collections;

public class WhiteBoxController : MonoBehaviour {

    private float alpha = 1f;
    public SpriteRenderer whiteSprite;

    void Awake()
    {
        transform.position = new Vector3(0, 0, 0);
        StartCoroutine(FadeOut());
    }

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void FadeInWhiteBox()
    {
        StartCoroutine(FadeIn());
    }

    IEnumerator FadeOut()
    {
        while (alpha > 0f)
        {
            alpha += -0.05f;
            whiteSprite.color = new Color(whiteSprite.color.r, whiteSprite.color.g, whiteSprite.color.b, alpha);
            yield return new WaitForSeconds(0.1f);
        }
    }

    IEnumerator FadeIn()
    {
        while (alpha < 1f)
        {
            alpha += 0.015f;
            whiteSprite.color = new Color(whiteSprite.color.r, whiteSprite.color.g, whiteSprite.color.b, alpha);
            yield return new WaitForSeconds(0.1f);
        }
    }
}
