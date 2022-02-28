using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyMouseClick : MonoBehaviour {

    Camera mainCamera;

    private void OnEnable() {
        MyClickButton.OnMyCoolEvent += OnMyCoolEvent;
    }
    private void OnDisable() {
        MyClickButton.OnMyCoolEvent -= OnMyCoolEvent;
    }
    void OnMyCoolEvent(int x) {
        Debug.Log("HEY COOL EVENT HAPPENING!!");
    }

    private void Awake() {
        mainCamera = Camera.main; //This gets the camera with the tag "Main Camera"
    }

    void ClickCheck() {
        if (Input.GetMouseButtonDown(0)) { //Mouse button 0 is the left click
            
            RaycastHit2D ray = Physics2D.GetRayIntersection(mainCamera.ScreenPointToRay(Input.mousePosition));

            //Okay, so here, I'm creating a raycast (2D! That's important for us because we're working in 2D space). 
            //I'm shooting a ray from the Main Camera using mainCamera.ScreenPointToRay
            //Where am I shooting it from? From the position of the mouse, which we get by calling Input.mousePosition (which is a vector 3)

            //Now I want to check if the ray hits something...

            if(ray.collider != null && ray.collider.GetComponent<MyClickButton>()) {
                ray.collider.GetComponent<MyClickButton>().SelectButton(0);
            }

        }

        if (Input.GetMouseButtonDown(1)) { //Mouse button 1 is the right click
            RaycastHit2D ray = Physics2D.GetRayIntersection(mainCamera.ScreenPointToRay(Input.mousePosition));
            //Okay, so here, I'm creating a raycast (2D! That's important for us because we're working in 2D space). 
            //I'm shooting a ray from the Main Camera using mainCamera.ScreenPointToRay
            //Where am I shooting it from? From the position of the mouse, which we get by calling Input.mousePosition (which is a vector 3)


        }
    }
}
