using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseBehaviour : MonoBehaviour {
    public enum MyGoodEnum { Good, Bad, Okay}
    public MyGoodEnum mGood = MyGoodEnum.Good;

    public float eatSpeed = 1.0f;
    public float shedAmount = 10.0f;

    public void Start() {
        ClassSetup();
    }

    public virtual void ClassSetup() {
        //Debug.Log($"Is this good? {mGood}");
    }

    public virtual void PrintThis(string x) {
        Debug.Log($"We are printing this: {x}");
    }

    /// <summary>
    /// Returns true if a number is between a certain range (Inclusive)
    /// </summary>
    /// <param name="n"></param>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <returns></returns>
    protected bool IsBetween(int n, int x, int y) {
        bool b = false;
        int l;
        int u;

        if(x == y)
            return false;

        if(x > y) {
            l = y; 
            u = x;
        }
        else {
            l = x;
            u = y;
        }

        if(n >= l && n <= u) {
            b = true;
        }

        //if (n < y)
        //    return x > n && x < y;
        //else
        //    return x > y && x < n;

        return b;
    }


}
