using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class CambiarSnapshot : MonoBehaviour

{
    public AudioMixer audioMixer1; // El Audio Mixer al que se aplicar� el cambio de Snapshot.
    public AudioMixerSnapshot snapshotOrigen; // Snapshot inicial (el que est� activo al principio).
    public AudioMixerSnapshot snapshotDestino; // Snapshot al que deseas cambiar con el fade in.

    public float tiempoFadeIn = 2.0f; // Duraci�n del fade in en segundos.

   
    public void CambiarASnapshot2ConFade()
    {
        audioMixer1.TransitionToSnapshots(new AudioMixerSnapshot[] { snapshotDestino }, new float[] { 1.0f }, tiempoFadeIn);
    }
}





