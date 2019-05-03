using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

    private int player1Score;
    private int player2Score;
    private const float SCREEN_WIDTH_HALF = 9f;
    private const float SCREEN_HEIGHT_HALF = 5f;
    private const float PADDLE_HEIGHT_HALF = 1.3f;
    [SerializeField] private float speed;
    [SerializeField] private Transform ball;
    [SerializeField] private GameObject left;
    [SerializeField] private GameObject right;
    private float x, y;
    [SerializeField] private float check;
    [SerializeField] private GUISkin layout;


    void Rand()
    {
        float rand = Random.Range(-10f, 10f);
        if (rand > 0)
        {
            x = 10f;
        }
        else
        {
            x = -10f;
        }
        rand = Random.Range(-10f, 10f);
        if (rand > 0)
        {
            y = 3f;
        }
        else
        {
            y = -3f;
        }
    }

    void Start () {
        player1Score = 0;
        player2Score = 0;
        Rand();
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(200 , 25, 100, 100), "" + player1Score);
        GUI.Label(new Rect(540, 25, 100, 100), "" + player2Score);
    }

    void Update () {
        transform.Translate(new Vector2(x, y) * Time.deltaTime);
        if (transform.position.x > SCREEN_WIDTH_HALF && (transform.position.y <= right.transform.position.y + PADDLE_HEIGHT_HALF)
            && (transform.position.y >= right.transform.position.y - PADDLE_HEIGHT_HALF))
        {
            x *= -1;
        }
        else if (transform.position.x < -SCREEN_WIDTH_HALF && (transform.position.y <= left.transform.position.y + PADDLE_HEIGHT_HALF)
            && (transform.position.y >= left.transform.position.y - PADDLE_HEIGHT_HALF))
        {

            x *= -1;
        }
        if(transform.position.y > SCREEN_HEIGHT_HALF || transform.position.y < -SCREEN_HEIGHT_HALF)
        {
            y *= -1;
        }
        if(transform.position.x > SCREEN_WIDTH_HALF + check)
        {
            player1Score++;
            transform.position = Vector3.zero;
        }
        if (transform.position.x < -SCREEN_WIDTH_HALF - check)
        {
            player2Score++;
            transform.position = Vector3.zero;
        }
    }
}
