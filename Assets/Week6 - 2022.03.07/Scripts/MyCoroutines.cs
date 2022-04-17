using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MyCoroutines : MonoBehaviour {

    public TMP_Text myText;

    private void Start() {
        StartCoroutine(CoroutineOne());
    }

    IEnumerator CoroutineOne() {
        myText.text = "Coroutine one has started...";
        yield return StartCoroutine(CoroutineTwo());
        myText.text += "\nCoroutine one has finished!!";
    }

    IEnumerator CoroutineTwo() {
        yield return new WaitForSeconds(1.0f);
        myText.text += "\nCoroutine two has started...";
        yield return StartCoroutine(CoroutineThree());
        myText.text += "\nCoroutine two has ended!!!";
        yield return new WaitForSeconds(1.0f);
    }

    IEnumerator CoroutineThree() {
        yield return new WaitForSeconds(1.0f);
        myText.text += "\nCoroutine three has started...";
        bool b = true;
        myText.text += "\nWaiting for player to press SPACE...";
        while (b) {
            if (Input.GetKeyDown(KeyCode.Space))
                b = false;
            yield return null;
        }
        yield return new WaitForSeconds(1.0f);
        myText.text += "\nCoroutine three has ended!!!";

    }

}
