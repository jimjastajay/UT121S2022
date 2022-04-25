using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Blink : MonoBehaviour {

    public RectTransform rectTransform;
    public float pauseTime = 0.5f;
    IEnumerator Start() {
        while (true) {
            yield return StartCoroutine(Blinking());
            yield return new WaitForSeconds(1.0f);
        }
    }

    IEnumerator Blinking() {
        float t = 0.0f;
        Vector3 start = rectTransform.localScale;
        Vector3 end = new Vector3(rectTransform.localScale.x, 0.0f, 1.0f);
        while (t < 1.0f) {
            t += Time.deltaTime;
            Debug.Log(t);
            rectTransform.localScale = Vector3.Lerp(start, end, t);
            yield return null;
        }
        t = 0.0f;
        yield return new WaitForSeconds(pauseTime);
        while (t < 1.0f) {
            t += Time.deltaTime;
            rectTransform.localScale = Vector3.Lerp(end, start, t);
            yield return null;
        }
    }

}
