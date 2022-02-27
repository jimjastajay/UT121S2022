using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Roomba : MonoBehaviour {


    public bool objectInWay = false;
    public float speed = 1.0f;
    public float raycastDistance = 1.0f;
    public bool movingLeft = true;
    Vector2 dir;

    void MoveRoomba() {

        dir = movingLeft ? Vector2.left : Vector2.right;
        RaycastHit2D hit = Physics2D.Raycast(transform.position, dir, raycastDistance);

        transform.Translate(dir * speed * Time.deltaTime);

        if (hit.collider != null) {
            movingLeft = !movingLeft;
        }
    }

    private void OnDrawGizmos() {
        Gizmos.color = movingLeft ? Color.magenta : Color.gray;
        Gizmos.DrawRay(transform.position, dir * raycastDistance);
    }

    private void Update() {
        MoveRoomba();
    }
}
