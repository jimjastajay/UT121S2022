using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IrisMovement : MonoBehaviour {
    public float moveSpeed;
    public AnimationCurve xMovement, yMovement;

    private void Start() {
        StartCoroutine(EyeMovementRoutine());
    }

    public IEnumerator EyeMovementRoutine() {
        float t = 0.0f;
        while (true) {
            while (t < 1.0f) {
                t += Time.deltaTime * moveSpeed;
                transform.localPosition = new Vector3(xMovement.Evaluate(t), yMovement.Evaluate(t), 0.0f);
                yield return null;
            }
            yield return null;
            t = 0.0f;
        }
    }
}
