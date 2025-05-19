using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveWithRigitbody : MonoBehaviour
{
    Rigidbody2D player;
    public float speed;
    private float x;
    private float y;
    // Start is called before the first frame update
    void Start()
    {
        player = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
        Vector2 addVec = new Vector2(x * speed * Time.deltaTime, y * speed * Time.deltaTime);
        player.MovePosition(player.position + addVec);
        //player.velocity += addVec;
    }
}
