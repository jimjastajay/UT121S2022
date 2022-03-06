using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class KeyboardKey : MonoBehaviour {

    public enum Accidental { Natural, Sharp }
    public Accidental acc = Accidental.Natural;

    AudioSource audioSource;
    public KeyCode keyboardLetter;
    public AudioClip clip;

    float basePitch = 1.0f;
    float diff = 1.05946f - 1.0f;

    private void Awake() {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = clip;
    }

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
        audioSource.PlayOneShot(clip);
    }


    private void Update() {
        if (Input.GetKeyDown(keyboardLetter)) {
            if (Input.GetKey(KeyCode.LeftShift)) {
                audioSource.pitch = basePitch * 2;
            }
            else {
                audioSource.pitch = basePitch;
            }
            PlayKey();
        }

    }

}
