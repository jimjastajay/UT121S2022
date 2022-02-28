using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyRoomba : MonoBehaviour {

    public float speed = 1.0f;
    public float raycastDistance = 1.0f;
    public bool movingLeft = true;
    Vector2 direction = Vector2.left;

    void MoveRoomba() {

        //if (movingLeft)
        //    direction = Vector2.left;
        //else if (!movingLeft)
        //    direction = Vector2.right;

        direction = movingLeft ? Vector2.left : Vector2.right;

        RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, raycastDistance);

        transform.Translate(direction * speed * Time.deltaTime);

        if(hit.collider != null) {
            movingLeft = !movingLeft;
        }
    }

    private void OnDrawGizmos() {
        Gizmos.color = movingLeft ? Color.magenta : Color.yellow;
        Gizmos.DrawRay(transform.position, direction * raycastDistance);
    }

    private void Update() {
        MoveRoomba();
    }

}
