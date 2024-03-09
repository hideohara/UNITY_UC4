using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody rb;
    private float moveSpeed = 5;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // �E
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = new Vector3(1, 0, 0) * moveSpeed;
            animator.SetBool("WalkFlag", true);
            transform.rotation = Quaternion.Euler(0, 90, 0);
        }
        // ��
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector3(-1, 0, 0) * moveSpeed;
            animator.SetBool("WalkFlag", true);
            transform.rotation = Quaternion.Euler(0, -90, 0);
        }
        // ��
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.velocity = new Vector3(0, 0, 1) * moveSpeed;
            animator.SetBool("WalkFlag", true);
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        // ��O
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.velocity = new Vector3(0, 0, -1) * moveSpeed;
            animator.SetBool("WalkFlag", true);
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else
        {
            animator.SetBool("WalkFlag", false);
            rb.velocity = new Vector3(0, 0, 0);
        }

    }
}
