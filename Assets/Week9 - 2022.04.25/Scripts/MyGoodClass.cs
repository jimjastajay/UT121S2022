using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyGoodClass : BaseBehaviour {

    [Header("My Good Class Variables")]
    public float flySpeed;

    public List<NewBreakpointTestClass> nclasses = new List<NewBreakpointTestClass>();

    private void Start() {
        //Debug.Log(IsBetween(3, 0, 10));
        //Debug.Log(IsBetween(-1, 0, 10));
        //Debug.Log(IsBetween(44, 90, 1));

        for(int i = 0; i < 100; i++) {
            int n = Random.Range(0, 100);
            if(n < 50) {
                nclasses.Add(new NewBreakpointTestClass());
            }
            else {
                nclasses.Add(new NewBreakpointTestClass(5, $"Class: {i}"));
            }
        }
    }

    public override void ClassSetup() {
        //base.ClassSetup();
        //Debug.Log($"Class Setup Override: {mGood}");

    }

    public override void PrintThis(string x) {
        //Debug.LogWarning($"Override is printing this other thing: {x}");
    }
}

[System.Serializable]
public class NewBreakpointTestClass {
    public int x = 4;
    public string n = "Hey";

    public NewBreakpointTestClass() {

    }
    public NewBreakpointTestClass(int i, string s) {
        x = i;
        n = s;
    }
}
