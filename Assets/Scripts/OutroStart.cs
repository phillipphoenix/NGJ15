using UnityEngine;
using System.Collections;

public class OutroStart : MonoBehaviour {

    private BackgroundMusicManager bgmm;
    public AudioSource endMusic;
    WhiteBoxController wbc;

    void Awake()
    {
        wbc = GameObject.Find("WhiteBox").GetComponent<WhiteBoxController>();
        bgmm = GameObject.Find("BackgroundMusic").GetComponent<BackgroundMusicManager>();
    }

	void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.tag == "Player")
        {
            Debug.Log("game over");
            GameEventManager.gameOver = true;
            bgmm.FadeOutAllMusic();
            AudioSource.PlayClipAtPoint(endMusic.clip, Vector3.zero);
            wbc.FadeInWhiteBox();

        }
    }
}
