using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyClickButton : MonoBehaviour {

    public delegate void MyCoolEvent(int x);
    public static event MyCoolEvent OnMyCoolEvent;

    SpriteRenderer spriteRenderer;

    private void Awake() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    IEnumerator Start() {
        yield return new WaitForSeconds(2.0f);
        OnMyCoolEvent.Invoke(5);
    }

    public void SelectButton(int x) {
        if (x == 0)
            spriteRenderer.color = Color.red;
        else if(x == 1)
            spriteRenderer.color = Color.green;
    }
}