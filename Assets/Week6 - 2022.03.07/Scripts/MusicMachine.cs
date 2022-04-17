using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicMachine : MonoBehaviour {
    AudioSource drumAudio;

    private void Awake() {
        drumAudio = GetComponent<AudioSource>();
    }

    void PlayDrumLoop() {
        if (Input.GetKeyDown(KeyCode.P) && !drumAudio.isPlaying)
            drumAudio.Play();
        else if (Input.GetKeyDown(KeyCode.P) && drumAudio.isPlaying)
            drumAudio.Pause();
    }
    void StopDrumLoop() {
        if(Input.GetKeyDown(KeyCode.Q))
            drumAudio.Stop();
    }

    void DrumMachineInput() {
        PlayDrumLoop();
        StopDrumLoop();
    }

    private void Update() {
        DrumMachineInput();
    }

}
