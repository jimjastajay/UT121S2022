using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour {
    Shooting shoot;
    Rigidbody2D rb;
    Vector2 rPoint;
    // Start is called before the first frame update
    void Start() {
        rPoint = this.transform.position;
        shoot = GameObject.Find("GameManager").GetComponent<Shooting>();
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update() {

    }

    void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.name == "Floor") {
            transform.position = rPoint;
            rb.velocity = Vector2.zero;
            shoot.canShoot = true;

        }



    }
}