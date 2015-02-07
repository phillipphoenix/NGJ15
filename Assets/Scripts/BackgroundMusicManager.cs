using UnityEngine;
using System.Collections;

public enum MusicState
{

}

public class BackgroundMusicManager : MonoBehaviour
{
    public AudioSource audioStart, musicGrass, musicGrassSeq, musicWater, musicStone, musicConstant;

    void Start()
    {
        //AudioSource.PlayClipAtPoint(audioStart, Vector3.zero, 1f);
        musicConstant.volume = 1f;
        audioStart.volume = 0f;
    }

    public void ChangeMusic()
    {
        //musicConstant.volume = 1f;
        StartCoroutine(FadeIn(audioStart));
        StartCoroutine(FadeOut(musicConstant));
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
