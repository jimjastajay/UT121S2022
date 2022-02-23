using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CircleCollider2D))]

public class PegsDestroy : MonoBehaviour {
    public float timeRemaining = 10;
    SpriteRenderer spriteRenderer;
    CircleCollider2D circleCollider;

    bool isHit = false;
    bool ballReset = false;

    private void Awake() {
        spriteRenderer = GetComponent<SpriteRenderer>();
        circleCollider = GetComponent<CircleCollider2D>();
    }
    private void OnCollisionEnter2D(Collision2D collision) {
        isHit = true;

    }

    private void Update() {
        //if ()
        if (isHit) {
            spriteRenderer.color = new Color(176, 0, 0, 255);
            Destroy(circleCollider);

            if (ballReset) {
                Destroy(gameObject);
            }

        }

        if (timeRemaining > 0) {
            timeRemaining -= Time.deltaTime;
        }
        else {
            ballReset = true;
        }

        //if (gameObject.)
    }

    //check location of ball in ref to camera; then destroy the balls
    //or every time the ball is reset
}



