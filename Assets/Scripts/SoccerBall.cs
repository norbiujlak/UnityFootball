using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoccerBall : MonoBehaviour
{

    public float MovemementSpeed;
    private float targetX;
    private float targetY;
    int test = 0;
    bool hsoot;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        test++;

        if(test > 240)
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            test = 0;
            hsoot = false;
        }
        //if (Mathf.Abs((targetX - transform.position.x)) < 0.1 && Mathf.Abs((targetY - transform.position.y)) < 0.1)
        //{
        //     GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        //}
    }

    public void setInitialPosition()
    {
        transform.position = new Vector3(0, 0, 0);
    }
     
    public void Kick(float playerX, float playerY)
    {
        float moveX = transform.position.x - playerX;
        float moveY = transform.position.y - playerY;
        float distance = General.CalculateDistanceOfTwoPoints(playerX, playerY, transform.position.x, transform.position.y);
        targetX = moveX ;
        targetY = moveY ;
        //transform.Translate(moveX / distance, MovemementSpeed * moveY / distance, 0);

        bool hsoot = true;
        GetComponent<Rigidbody2D>().velocity = new Vector2(moveX * 10,   moveY * 10);

       // Vector3 shoot = (target.position - ball.transform.position).normalized;
      //  GetComponent<Rigidbody2D>().AddForce(shoot * 500.0f);

      //  Vector3 LeftCurlForce = new Vector3(30, 30).normalized * MovemementSpeed * 40;
       
        //GetComponent<Rigidbody2D>().isKinematic = false;

      //  GetComponent<Rigidbody2D>().AddForce(LeftCurlForce);
    }

    public bool KickIsPossible(float playerX, float playerY)
    {
        float moveX = transform.position.x - playerX;
        float moveY = transform.position.y - playerY;
        float distance = General.CalculateDistanceOfTwoPoints(playerX, playerY, transform.position.x, transform.position.y);
        if (distance < 30.0)
            return true;
        else
            return false;
    }
}
