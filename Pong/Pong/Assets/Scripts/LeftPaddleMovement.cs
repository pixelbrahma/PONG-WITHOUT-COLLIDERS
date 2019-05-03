using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftPaddleMovement : MonoBehaviour {

    private const float PADDLE_HEIGHT_HALF = 1.3f;
    private const float SCREEN_HEIGHT_HALF = 5f;
    [SerializeField] private Transform player1;
    [SerializeField] private float speed;

	void Start () {
		
	}
	
	void Update () {
		if(Input.GetKey(KeyCode.W) && (transform.position.y < (SCREEN_HEIGHT_HALF - PADDLE_HEIGHT_HALF)))
        {
            transform.Translate(new Vector3(0f, 5f, 0f) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S) && (transform.position.y > (-SCREEN_HEIGHT_HALF + PADDLE_HEIGHT_HALF)))
        {
            transform.Translate(new Vector3(0f, -5f, 0f) * Time.deltaTime);
        }
    }
}
