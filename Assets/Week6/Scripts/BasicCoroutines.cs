using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicCoroutines : MonoBehaviour {

    public SpriteRenderer spriteRenderer;
    public float changeSpeed = 1.0f;

    private void Start() {
        //StartCoroutine(MyCoroutine());
        //StartCoroutine(MySecondCoroutine("HEY!"));
        //StartCoroutine("MySecondCoroutine", "here is a message");

        //StartCoroutine(CoroutineOne());

        //StartCoroutine(OverTime());
        //StartCoroutine(OverTime(5.0f));

        StartCoroutine(ColorChange(Color.yellow, Color.cyan, 5.0f));

    }

    IEnumerator MyCoroutine() {
        Debug.Log("This is a debug statement running right away");
        yield return new WaitForSeconds(2.0f);
        Debug.Log("Hey this is code running after 2 seconds");
    }

    IEnumerator MySecondCoroutine(string msg) {
        yield return new WaitForSeconds(1.0f);
        Debug.Log(msg);
    }

    IEnumerator ThirdCoroutine(float s, string msg) {
        Debug.Log($"Let's wait for {s} second(s)");
        yield return new WaitForSeconds(s);
        Debug.Log(msg);
    }

    IEnumerator CoroutineOne() {
        Debug.Log("Coroutine One Has Started. Now waiting for Coroutine Two to finish");
        yield return new WaitForSeconds(1.0f);
        yield return StartCoroutine(CoroutineTwo());
        yield return new WaitForSeconds(1.0f);
        Debug.Log("Coroutine One has ended");

    }

    IEnumerator CoroutineTwo() {
        Debug.Log("Coroutine Two Has Started.");
        yield return new WaitForSeconds(2.0f);
        yield return StartCoroutine(CoroutineThree());
        yield return new WaitForSeconds(1.0f);
        Debug.Log("Coroutine Two Has Ended.");
    }

    IEnumerator CoroutineThree() {
        bool b = false;
        Debug.Log("Coroutine three has started. Waiting for input...");
        while (!b) {
            if (Input.GetKeyDown(KeyCode.Space))
                b = true;
            yield return null;
        }
        yield return new WaitForSeconds(1.0f);
        Debug.Log("Coroutine three has eneded because you have press the space bar!");
    }

    IEnumerator OverTime() {
        Debug.Log("Over time has started!");
        float t = 0.0f;
        while (t < 1.0f) {
            t += Time.deltaTime;
            yield return null;
        }
        Debug.Log("Over time is finished!");
    }
    IEnumerator OverTime(float t) {
        Debug.Log("Over time has started!");
        float a = 0;
        while(a < t) {
            a += Time.deltaTime;
            yield return null;
        }
        Debug.Log("Over time is finished!");
    }

    IEnumerator ColorChange(Color cOne, Color cTwo) {
        bool b = false;
        while (!b) {
            if (Input.GetKeyDown(KeyCode.Space))
                b = true;
            yield return null;
        }
        float t = 0.0f;
        Debug.Log("Color change started");
        while(t < 1.0f) {
            spriteRenderer.color = Color.Lerp(cOne, cTwo, t);
            t += Time.deltaTime * changeSpeed;
            yield return null;
        }
        Debug.Log("Color change finished");
    }

    IEnumerator ColorChange(Color cOne, Color cTwo, float e) {
        bool b = false;
        while (!b) {
            if (Input.GetKeyDown(KeyCode.Space))
                b = true;
            yield return null;
        }
        float t = 0.0f;
        Debug.Log("Color change started");
        while (t < e) {
            spriteRenderer.color = Color.Lerp(cOne, cTwo, t/e);
            t += Time.deltaTime;
            Debug.Log(t);
            yield return null;
        }
        Debug.Log("Color change finished");
    }
}
