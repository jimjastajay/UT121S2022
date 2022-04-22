using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodClass : MyBehaviour {

    //private void Start() {
    //    Debug.Log(IsBetween(3, 0, 10));
    //    Debug.Log(IsBetween(-1, 0, 10));
    //    Debug.Log(IsBetween(44, 90, 10));
    //}

    public override void ClassSetup() {
        base.ClassSetup();
        Debug.Log($"Hey, do we know what this thing is? {thisThing}");
    }
}
