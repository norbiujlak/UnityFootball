using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float MovemementSpeed;
    private SoccerBall ball;

    // Start is called before the first frame update
    void Start()
    {
        ball = GameObject.Find("Ball").GetComponent<SoccerBall>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) && transform.position.y < 83.0)
        {
            transform.Translate(0, MovemementSpeed, 0);
        }
        else if (Input.GetKey(KeyCode.DownArrow) && transform.position.y > -84.0)
        {
            transform.Translate(0, (-1) * MovemementSpeed, 0);
        }
        else if(Input.GetKey(KeyCode.RightArrow) && transform.position.x < 160.0)
        {
            transform.Translate(MovemementSpeed, 0, 0);
        }
        else if(Input.GetKey(KeyCode.LeftArrow) && transform.position.x > -159.0)
        {
            transform.Translate((-1) * MovemementSpeed, 0, 0);
        }
        else if (Input.GetKeyDown(KeyCode.Space) && ball.KickIsPossible(transform.position.x, transform.position.y))
        {
            ball.Kick(transform.position.x, transform.position.y);
        }
    }

    public void setInitialPosition()
    {
        transform.position = new Vector3(-5, 0, 0);
    }
}
