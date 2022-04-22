using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

[CreateAssetMenu(menuName = "All Levels Object", fileName = "All Levels Object")]
public class AllLevelsObject : ScriptableObject {

    public List<Level> levels = new List<Level>();
    void Sort() {
        List<Level> newList = levels.OrderBy(x => x.levelNumber).ToList();
    }

    public void AddLevel() {
        levels.Add(new Level("New level " + levels.Count, levels.Count));
    }
}

[System.Serializable]
public class Level {
    public int levelNumber = 0;
    public LevelType levelType = LevelType.Grass;
    public string levelName = "New Level";
    public int enemyCount = 10;
    public float timeLimit = 100.0f;
    public float bossSpawnPerct = 0.10f;

    public Level() {}

    public Level(string n, int i) {
        levelName = n;
        levelNumber = i;
    }
}
