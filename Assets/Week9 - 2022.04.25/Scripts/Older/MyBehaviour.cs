using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBehaviour : MonoBehaviour {

    public ThisThing thisThing = ThisThing.None;

    /// <summary>
    /// Returns true or false if a number is between a certain range. Inclusive
    /// </summary>
    /// <param name="n">The value we are checking</param>
    /// <param name="x">One number to check between</param>
    /// <param name="y">Another number to check between</param>
    protected bool IsBetween(int n, int x, int y) {
        bool b = false;
        int l;
        int u;

        if (x == y)
            return false;

        if(x > y) {
            l = y;
            u = x;
        }
        else {
            l = x;
            u = y;
        }

        if (n >= l && n <= u)
            b = true;
        
        return b;
    }

    public void Start() {
        ClassSetup();
    }

    public virtual void ClassSetup() {
        Debug.Log($"What is this thing? {thisThing}");
    }
}

    public enum ThisThing { None, GoodThing, BadThing, NeutralThing}