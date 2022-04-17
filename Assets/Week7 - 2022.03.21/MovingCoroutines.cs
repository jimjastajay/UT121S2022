using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MovingCoroutines : MonoBehaviour {

    public enum MoveType { Normal, EaseIn, EaseOut, SmoothStep }
    public MoveType moveType = MoveType.Normal;

    public Vector3 start;
    public Vector3 end;
    public float moveSpeed = 1.0f;
    public float startDelay = 1.0f;


    // Start is called before the first frame update
    void Start() {

        switch (moveType) {
            case MoveType.Normal:
                StartCoroutine(NormalMove(start, end, moveSpeed, startDelay));
                break;

            case MoveType.EaseIn:
                StartCoroutine(EaseIn(start, end, moveSpeed, startDelay));
                break;

            case MoveType.EaseOut:
                StartCoroutine(EaseOut(start, end, moveSpeed, startDelay));
                break;

            case MoveType.SmoothStep:
                StartCoroutine(SmoothStep(start, end, moveSpeed, startDelay));
                break;
        }

    }

    IEnumerator NormalMove(Vector3 s, Vector3 e, float sp, float sd) {
        transform.position = s;
        yield return new WaitForSeconds(sd);
        float lerpTime = 0.0f;
        while (Vector3.Distance(s, e) > 0.0f) {
            transform.position = Vector3.Lerp(s, e, lerpTime);
            lerpTime += Time.deltaTime;
            yield return null;
        }
        transform.position = e;
        yield return new WaitForSeconds(1.0f);
    }

    IEnumerator EaseIn(Vector3 s, Vector3 e, float sp, float sd) {
        transform.position = s;
        yield return new WaitForSeconds(sd);

        float currentLerpTime = 0.0f;
        float lerpTime = 1.0f;
        float t = 0.0f;

        while (t < 1.0f) {
            currentLerpTime += Time.deltaTime * sp;
            if (currentLerpTime > lerpTime) {
                currentLerpTime = lerpTime;
            }
            t = currentLerpTime / lerpTime;
            t = Mathf.Sin(t * Mathf.PI * 0.5f);
            transform.position = Vector3.Lerp(s, e, t);
            yield return null;
        }
        transform.position = e;
    }

    IEnumerator EaseOut(Vector3 s, Vector3 e, float sp, float sd) {
        transform.position = s;
        yield return new WaitForSeconds(sd);
        float currentLerpTime = 0.0f;
        float lerpTime = 1.0f;
        float t = 0.0f;
        while (t < 1.0f) {
            currentLerpTime += Time.deltaTime * sp;
            if (currentLerpTime > lerpTime) {
                currentLerpTime = lerpTime;
            }
            t = currentLerpTime / lerpTime;
            t = 1.0f - Mathf.Cos(t * Mathf.PI * 0.5f);
            transform.position = Vector3.Lerp(s, e, t);
            yield return null;
        }
        transform.position = e;
    }
    IEnumerator SmoothStep(Vector3 s, Vector3 e, float sp, float sd) {
        float currentLerpTime = 0.0f;
        float lerpTime = 1.0f;
        float t = 0.0f;
        yield return new WaitForSeconds(sd);
        while(t < 1.0f) {
            currentLerpTime += Time.deltaTime * sp;
            if(currentLerpTime > lerpTime) {
                currentLerpTime = lerpTime;
            }
            t = currentLerpTime / lerpTime;
            t = t * t * (3.0f - 2.0f * t);
            transform.position = Vector3.Lerp(s, e, t);
            yield return null;
        }
        transform.position = e;
    }

    private void Update() {
        if (Input.GetKey(KeyCode.LeftShift)) {
            if (Input.GetKeyDown(KeyCode.R)) {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
