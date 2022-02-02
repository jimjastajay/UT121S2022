using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMove : MonoBehaviour
{
    public enum Stages{ Attack, Defend, Flee }
    public Stages stages = Stages.Attack;

    Transform simpleObject;
    [SerializeField]
    float speed = 1.0f;
    [SerializeField]
    float origSpeed;
    [SerializeField]
    float sprintMultiply = 2.0f;

    private void Start()
    {
        origSpeed = speed;

        if(stages == Stages.Attack)
        {

        }

    }

    void MoveObject()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = origSpeed * sprintMultiply;
        } else
        {
            speed = origSpeed;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate((Vector2.left * Time.deltaTime) * speed);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate((Vector2.right * Time.deltaTime) * speed);
        }
    }

    // Update is called once per frame
    void Update()
    {
        MoveObject();
    }
}
