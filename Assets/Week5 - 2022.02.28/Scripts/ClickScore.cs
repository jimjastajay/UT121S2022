using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClickScore : MonoBehaviour {
    public TMP_Text text;
    public int score = 0;
    // Start is called before the first frame update

    // Update is called once per frame
    public void AddScoreByOne() {
        score += 1;
        text.text = score.ToString();
    }
    public void SubtractScoreByOne() {
        score -= 1;
        text.text = score.ToString();
    }

}