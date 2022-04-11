using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LevelInfoUI : MonoBehaviour {

    public TMP_Text levelInfoText;
    public int currentLevel = 0;
    public AllLevelsObject levelsObject;

    public void ShowLevelInfo() {
        Level l = levelsObject.levels[currentLevel];
        levelInfoText.text = $"Level Name {l.levelName}\n Enemy Count {l.enemyCount}\n Time Limit {l.timeLimit}";
    }
}
