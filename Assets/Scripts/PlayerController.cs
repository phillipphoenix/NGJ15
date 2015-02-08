using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public float speed;
    Animator anim;

    public Transform target;

    void Awake()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (GameEventManager.gameOver == true)
        {
            anim.SetBool("Walking", false);
            return;
        }

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        /*Vector3 temp = transform.position;
        temp.x += speed * h * Time.deltaTime;
        temp.y += speed * v * Time.deltaTime;
        transform.position = temp;*/
        rigidbody2D.velocity = new Vector2(h, v);
        rigidbody2D.velocity = rigidbody2D.velocity.normalized * speed * Time.deltaTime;

        if (v != 0f || h != 0f)
        {
            anim.SetBool("Walking", true);
        }
        else
        {
            anim.SetBool("Walking", false);
        }

        if (h != 0f || v != 0f)
        {
            float angle = Mathf.Atan2(h, v) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, -Vector3.forward);
        }

        

    }
}
