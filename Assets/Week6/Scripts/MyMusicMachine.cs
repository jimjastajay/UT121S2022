using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyMusicMachine : MonoBehaviour {

    AudioSource audioSource;

    private void Awake() {
        audioSource = GetComponent<AudioSource>();
    }

    void PlayDrumLoop() {
        if (Input.GetKeyDown(KeyCode.P) && !audioSource.isPlaying)
            audioSource.Play();
        else if (Input.GetKeyDown(KeyCode.P) && audioSource.isPlaying)
            audioSource.Pause();
    }

    void StopDrumLoop() {
        if(Input.GetKeyDown(KeyCode.Q))
            audioSource.Stop();
    }

    void DrumMachineInput() {
        PlayDrumLoop();
        StopDrumLoop();
    }

    private void Update() {
        DrumMachineInput();
    }
}
