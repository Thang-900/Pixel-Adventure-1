using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeanimation : MonoBehaviour
{
    private Animator animator;
    private int numbers;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            numbers = 1;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            numbers = 2;
        }
        else
        {
            numbers = 0;
        }
        animator.SetInteger("state", numbers);
    }
}
