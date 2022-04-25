using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnotherGoodClass : MonoBehaviour {

    public BaseBehaviour bb;
    public MyGoodClass mgc;

    // Start is called before the first frame update
    void Start() {
        bb.PrintThis("This!!");
        mgc.PrintThis("Another This!!");
    }

    // Update is called once per frame
    void Update() {

    }
}
