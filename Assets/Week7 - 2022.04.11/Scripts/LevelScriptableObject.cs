using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Level", menuName = "New Level Asset")]
public class LevelScriptableObject : ScriptableObject {

    public LevelType levelType = LevelType.Grass;
    public int levelNumber = 0;
    public string levelName = "New Level";
    public int enemyCount = 10;
    public float timeLimit = 100.0f;
}


public enum LevelType { Grass, Water, Sky, Cave}