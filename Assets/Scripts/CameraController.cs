using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
    Transform player;
    public float smooth;

    void Awake()
    {
        player = GameObject.Find("Player").GetComponent<Transform>();
    }

    void Update()
    {
        Vector3 temp = Vector3.Lerp(transform.position, player.position, smooth);
        temp.z = -10f;
        transform.position = temp;
    }
}
