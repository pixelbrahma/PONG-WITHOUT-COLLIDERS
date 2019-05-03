using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightPaddleMovement : MonoBehaviour {

    private const float PADDLE_HEIGHT_HALF = 1.3f;
    private const float SCREEN_HEIGHT_HALF = 5f;
    [SerializeField] private Transform player2;
    [SerializeField] private float speed;

	void Start () {
	}


    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) && (transform.position.y < (SCREEN_HEIGHT_HALF - PADDLE_HEIGHT_HALF)))
        {
            transform.Translate(new Vector3(0f, 5f, 0f) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow) && (transform.position.y > (-SCREEN_HEIGHT_HALF + PADDLE_HEIGHT_HALF)))
        {
            transform.Translate(new Vector3(0f, -5f, 0f) * Time.deltaTime);
        }
    }
}
