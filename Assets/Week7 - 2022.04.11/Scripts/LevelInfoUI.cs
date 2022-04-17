using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LevelInfoUI : MonoBehaviour {

    public TMP_Text levelInfoText;
    public int currentLevel = 0;
    public AllLevelsObject levelsObject;

    public Slider slider;
    public TMP_Text sliderText;
    

    private void Start() {
        //slider.onValueChanged.AddListener(ListenerOne);
        slider.onValueChanged.AddListener(delegate { ListenerTwo(); });
    }

    public void UpdateSlider() {
        Level l = levelsObject.levels[currentLevel];
        l.bossSpawnPerct = slider.value;
        sliderText.text = $"On Slider Value Change: {l.bossSpawnPerct}%";
    }

    public void ListenerOne(float x) {
        Level l = levelsObject.levels[currentLevel];
        l.bossSpawnPerct = slider.value;
        sliderText.text = $"Listener One Value Change: {l.bossSpawnPerct}%";
    }
    public void ListenerTwo() {
        Level l = levelsObject.levels[currentLevel];
        l.bossSpawnPerct = slider.value;
        sliderText.text = $"Listener Two Value Change: {l.bossSpawnPerct}%";
    }

    public void ShowLevelInfo() {
        Level l = levelsObject.levels[currentLevel];
        levelInfoText.text = $"Level Name: {l.levelName}\n Enemy Count {l.enemyCount}\n Time Limit {l.timeLimit}\n %% {l.bossSpawnPerct}%";
    }

    public void NextLevel() {
        currentLevel += 1;
        if(currentLevel >= levelsObject.levels.Count)
            currentLevel = 0;
        ShowLevelInfo();
    }
    public void PreviousLevel() {
        currentLevel -= 1;
        if(currentLevel < 0)
            currentLevel = levelsObject.levels.Count - 1;
        ShowLevelInfo();
    }


}
