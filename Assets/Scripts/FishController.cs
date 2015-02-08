using UnityEngine;
using System.Collections;

public class FishController : MonoBehaviour {

    public Transform target;

	// Use this for initialization
	void Start () {
        //iTween.PutOnPath(gameObject, iTweenPath.GetPath("FishPath"), 10);
        iTween.MoveTo(gameObject, iTween.Hash("path", iTweenPath.GetPath("FishPath"), "time", 20, "loopType", "loop", "delay", 0, "easetype", "linear"));
    }

    void Update()
    {
        float h = target.position.x - transform.position.x;
        float v = target.position.y - transform.position.y;

        float angle = Mathf.Atan2(h, v) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle - 90, -Vector3.forward);

        if (h != 0f || v != 0f)
        {
            
        }

        //iTween.RotateTo(gameObject, target.position, 1f);
    }
}
