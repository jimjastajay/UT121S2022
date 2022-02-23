using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLauncher : MonoBehaviour {
    public int Launch_Velocity;
    private Vector2 mousePos;
    private Vector2 delta;

    public GameObject ball;

    public bool canShoot = true; //set this to true when we're ready

    void Update() {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        delta = mousePos - (Vector2)transform.position;
        transform.eulerAngles = new Vector3(0, 0, Mathf.Rad2Deg * Mathf.Atan2(delta.y, delta.x));

        if (Input.GetMouseButton(0) && canShoot) {
            canShoot = false;
            GameObject newBall = Instantiate(ball, transform.position, transform.rotation);
            Vector2 velo = Launch_Velocity * delta.normalized; // transform.forward * Launch_Velocity;
            newBall.GetComponent<Rigidbody2D>().velocity = velo;
        }

    }

    public void Reload() {
        canShoot = true;
    }
}