using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToLocation : MonoBehaviour {

    BoxCollider2D boxCollider;
    SpriteRenderer spriteRenderer;
    public Transform mover;
    public Transform targetLocation;

    private void Awake() {
        boxCollider = GetComponent<BoxCollider2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void Start() {
        boxCollider.isTrigger = true;
    }

    //Hey this does something cool. It moves an object.
    private void OnTriggerEnter2D(Collider2D collision) {
        spriteRenderer.color = new Color(1.0f, 0.5f, 0.25f, 0.5f);
        //mover.position = new Vector3(5.0f, 0.0f, 0.0f);
        mover.position = targetLocation.position;
        Debug.Log("Enter Trigger");
    }
    /// <summary>
    /// Hey this is something else
    /// </summary>
    /// <param name="collision"></param>
    private void OnTriggerExit2D(Collider2D collision) {
        Debug.Log("Exit Trigger");
    }

}
