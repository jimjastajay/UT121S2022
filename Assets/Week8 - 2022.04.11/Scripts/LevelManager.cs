using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    public LevelScriptableObject myLevel;

    //This is a List of LevelScriptableObjects holding our lists
    public List<LevelScriptableObject> levelList = new List<LevelScriptableObject>();
    
    ///This is an array of levels using Level Scriptable Objects
    //public LevelScriptableObject[] arrayLevelList = new LevelScriptableObject[4];



    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }
}
