using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LevelInfoUI : MonoBehaviour {

    public TMP_Text levelInfoText;
    public int currentLevel = 0;
    public AllLevelsObject levelsObject;

    public static int bigNumber = 100;

    [Space]
    public Slider slider;
    public TMP_Text sliderText;
    protected int number = 10;

    private void OnEnable() {
        SimpleNPC.OnPlayerFun += OnPlayerFun;
    }
    private void OnDisable() {
        SimpleNPC.OnPlayerFun -= OnPlayerFun;
    }
    public void OnPlayerFun(string x) {
        Debug.LogWarning("The player is having fun!!");
        levelInfoText.text = $"{x} : The player *is* having fun!";
    }


    void Start() {
        
        slider.onValueChanged.AddListener(ListenerOne);
        slider.onValueChanged.AddListener(delegate { ListenerTwo(); });
    }
    public void ShowLevelInfo() {
        Level l = levelsObject.levels[currentLevel];
        levelInfoText.text = $"Level Name: {l.levelName}\n Enemy Count {l.enemyCount}\n Time Limit {l.timeLimit}\n %% {l.bossSpawnPerct}%";
    }

    public void ListenerOne(float x) {
        Level l = levelsObject.levels[currentLevel];
        l.bossSpawnPerct = slider.value;
        sliderText.text = $"Listener One: {slider.value}%";
    }
    public void ListenerTwo() {
        Level l = levelsObject.levels[currentLevel];
        l.bossSpawnPerct = slider.value;
        sliderText.text = $"Listener Two: {slider.value}%";
    }
    public void UpdateSlider() {
        Level l = levelsObject.levels[currentLevel];
        l.bossSpawnPerct = slider.value;
        sliderText.text = $"Slider Value: {slider.value}%";
    }
    public void Next() {
        currentLevel += 1;
        if (currentLevel >= levelsObject.levels.Count) {
            currentLevel = 0;
        }
        ShowLevelInfo();
    }
    public void Previous() {
        currentLevel -= 1;
        if (currentLevel < 0) {
            currentLevel = levelsObject.levels.Count - 1;
        }
        ShowLevelInfo();
    }
}