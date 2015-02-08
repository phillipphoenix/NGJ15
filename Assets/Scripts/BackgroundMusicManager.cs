using UnityEngine;
using System.Collections;

public class BackgroundMusicManager : MonoBehaviour
{
    public AudioSource audioStart, musicGrass, musicGrassSeq, musicWater, musicStone, musicConstant;
    private int state = 0;

    void Start()
    {
        ChangeMusic();
    }

    public void ChangeMusic()
    {
        state++;
        if (state == 1) // Begin state
        {
            StartCoroutine(FadeIn(audioStart));
        }
        else if (state == 2) // Grass state
        {
            StartCoroutine(FadeOut(audioStart));
            StartCoroutine(FadeIn(musicConstant));
            StartCoroutine(FadeIn(musicGrass));
        }
        else if (state == 3) // Water state
        {
            StartCoroutine(FadeIn(musicWater));
        }
        else if (state == 4) // Wooden plank encounter
        {
            StartCoroutine(FadeOut(musicGrass));
            StartCoroutine(FadeIn(musicGrassSeq));
        }
        else if (state == 5) // Sand state
        {
            StartCoroutine(FadeIn(musicStone));
        }
    }

    IEnumerator FadeIn(AudioSource audio)
    {
        while (audio.volume < 1f)
        {
            audio.volume += 0.1f;
            yield return new WaitForSeconds(0.2f);
        }
    }

    IEnumerator FadeOut(AudioSource audio)
    {
        while (audio.volume > 0f)
        {
            audio.volume -= 0.1f;
            yield return new WaitForSeconds(0.2f);
        }
    }
}
