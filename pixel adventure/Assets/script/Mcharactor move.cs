using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float speed;
    private bool isMoving;
    private int die;
    float moveForward;
    float moveup;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        moveForward = Input.GetAxis("Horizontal");
        Debug.Log($"hori { moveForward}");

        moveup = Input.GetAxis("Vertical");
        Debug.Log($"verti: {moveup}");
        //
        if(moveForward>0||moveup>0)
        {
            isMoving = true;
        }
        else if(die==2)
        {

        }
        else
        {
            isMoving = false;
        }
            transform.position += new Vector3(moveForward * speed * Time.deltaTime, moveup * speed * Time.deltaTime, 0f);
    }


}
