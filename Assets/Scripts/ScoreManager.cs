using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int rightScore;
    public int leftScore;
    private ChangeText changeText;
    private SoccerBall ball;
    private MovePlayer player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<MovePlayer>();
        ball = GameObject.Find("Ball").GetComponent<SoccerBall>();
        if (gameObject.name.Equals("RightScore"))
        {
            changeText = GameObject.Find("RightScoreBoard").GetComponent<ChangeText>();
        }
        else if (gameObject.name.Equals("LeftScore"))
        {
            changeText = GameObject.Find("LeftScoreBoard").GetComponent<ChangeText>();
        }
        rightScore = 0;
        leftScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (gameObject.name.Equals("RightScore"))
        {
            rightScore++;
        }
        else if (gameObject.name.Equals("LeftScore"))
        {
            leftScore++;
        }
        UpdateScoreBoard();
        SetInitialPositions();
    }

    private void UpdateScoreBoard()
    {
        if (gameObject.name.Equals("RightScore"))
        {
            changeText.myText.text = rightScore.ToString();
        }
        else if (gameObject.name.Equals("LeftScore"))
        {
            changeText.myText.text = leftScore.ToString();
        }
    }

    private void SetInitialPositions()
    {
        ball.setInitialPosition();
        player.setInitialPosition();
    }

}
