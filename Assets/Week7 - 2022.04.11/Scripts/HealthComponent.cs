using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthComponent : MonoBehaviour {

    public delegate void HealthHitZeroDelegate();
    public event HealthHitZeroDelegate OnHealthHitZero;
    public int health = 20;

    public void TakeDamage(int x) {
        health -= x;
        if(health <=  0)
            OnHealthHitZero?.Invoke();
    }

    public void Update() {
        if (Input.GetKeyDown(KeyCode.Space))
            TakeDamage(2);
    }

}
