using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Blink : MonoBehaviour {

    public float closePauseTime, openPauseTime = 0.5f;
    public float blinkSpeed = 1.0f;

    IEnumerator Start() {
        while (true) {
            yield return StartCoroutine(Blinking());
            yield return new WaitForSeconds(Random.Range(0.0f, openPauseTime));
        }
    }

    IEnumerator Blinking() {
        float t = 0.0f;
        Vector3 start = transform.localScale;
        Vector3 end = new Vector3(transform.localScale.x, 0.0f, 1.0f);
        while (t < 1.0f) {
            t += Time.deltaTime * blinkSpeed;
            transform.localScale = Vector3.Lerp(start, end, t);
            yield return null;
        }
        t = 0.0f;
        yield return new WaitForSeconds(Random.Range(0.0f, closePauseTime));
        while (t < 1.0f) {
            t += Time.deltaTime * blinkSpeed;
            transform.localScale = Vector3.Lerp(end, start, t);
            yield return null;
        }
    }

}
