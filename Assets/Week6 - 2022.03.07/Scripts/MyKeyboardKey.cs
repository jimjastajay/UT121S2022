using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class MyKeyboardKey : MonoBehaviour {

    public enum Accidental { Natural, Sharp }
    public Accidental acc = Accidental.Natural;

    public AudioSource audioSource;
    public KeyCode keyboardLetter;
    public AudioClip audioClip;

    float basePitch = 1.0f;
    float diff = 1.05946f - 1.0f;

    private void Start() {
        switch (acc) {
            case Accidental.Sharp:
                basePitch = 1.0f + diff;
                break;
            default:
                basePitch = 1.0f;
                break;
        }
    }

    void PlayKey() {
        audioSource.PlayOneShot(audioClip);
    }

    void Update() {
        if (Input.GetKeyDown(keyboardLetter)) {

            if (Input.GetKey(KeyCode.LeftShift)) {
                audioSource.pitch = basePitch * 2.0f;
            }
            else {
                audioSource.pitch = basePitch;
            }


            PlayKey();
        }
    }

}
