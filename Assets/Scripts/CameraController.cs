using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
    Transform player;
    public float smooth;
    Camera mainCamera;

    void Awake()
    {
        player = GameObject.Find("Player").GetComponent<Transform>();
        mainCamera = GameObject.Find("MainCamera").GetComponent<Camera>();
    }

    void Update()
    {
        Vector3 temp = Vector3.Lerp(transform.position, new Vector3(transform.position.x, player.position.y, player.position.z), smooth);
        temp.z = -10f;
        transform.position = temp;
    }

    public void ZoomSlowly(float newSize)
    {
        StartCoroutine(ChangeSize(newSize));
    }

    IEnumerator ChangeSize(float newSize)
    {
        while (mainCamera.orthographicSize < newSize)
        {
            mainCamera.orthographicSize += .02f;
            yield return new WaitForSeconds(0.06f);
        }
    }
}
