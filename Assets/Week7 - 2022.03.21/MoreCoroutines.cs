using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoreCoroutines : MonoBehaviour {

    public TMP_Text myText;
    public float waitingTime = 1.0f;

    public SpriteRenderer myCircle;

    public Color colorOne = Color.green;
    public Color colorTwo = Color.grey;
    public Color colorThree;

    private void Start() {
        //StartCoroutine(OverTime(5.0f));
        //StartCoroutine(OverTimeAgain());
        StartCoroutine(ColorChange(colorOne, colorTwo, waitingTime));
    }

    IEnumerator OverTime() {
        Debug.Log("We have started!");
        myText.text = "We have started!\n";
        float t = 0.0f;
        while(t < 1.0f) {
            t += Time.deltaTime;
            myText.text = t.ToString();
            yield return null;
        }
        myText.text += "\nWe have finished!";
        Debug.Log("We have finished!");
    }

    IEnumerator OverTime(float t) {
        myText.text = "We have started!\n";
        float a = 0.0f;
        while(a < t) {
            a += Time.deltaTime;
            yield return null;
        }
        myText.text += "We have finished!";
    }

    IEnumerator OverTimeAgain() {
        myText.text = "We have started again...\n";
        float a = 0.0f;
        while(a < waitingTime) {
            a += Time.deltaTime;
            yield return null;
        }
        myText.text += "We have finished yet again!";

    }

    IEnumerator ColorChange(Color cOne, Color cTwo) {
        myCircle.color = cOne;
        bool b = false;
        while (!b) {
            if (Input.GetKeyDown(KeyCode.Space)) {
                b = true;
            }
            yield return null;
        }

        float t = 0.0f;
        myText.text = "Color Change Started!!\n";
        while(t < 1.0f) {
            myCircle.color = Color.Lerp(cOne, cTwo, t);
            t += Time.deltaTime;
            yield return null;
        }
        myText.text += "Color Change Finished";
    }

    IEnumerator ColorChange(Color cOne, Color cTwo, float e) {
        myCircle.color = cOne;
        bool b = false;
        while (!b) {
            if (Input.GetKeyDown(KeyCode.Space)) {
                b = true;
            }
            yield return null;
        }
        float t = 0.0f;
        myText.text = $"Color Change Started: {cOne}!!!!\n";
        while(t < e) {
            myCircle.color = Color.Lerp(cOne, cTwo, t / e);
            t += Time.deltaTime;
            yield return null;
        }
        myText.text += "Color Change Finished!";
    }



}
