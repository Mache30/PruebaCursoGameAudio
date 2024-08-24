using SUPERCharacter;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Audio;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverCanvas;
    private bool juegoTerminado = false;
    SUPERCharacterAIO player;
    Vida life;
    public AudioMixer playerMixer;
    public AudioClip deathClip;
    AudioSource death;
    // Start is called before the first frame update
    void Start()
    {
        GameObject playerObject = GameObject.FindWithTag("Player");
        life = playerObject.GetComponent<Vida>();
        player = playerObject.GetComponent<SUPERCharacterAIO>();
        death = GetComponent<AudioSource>();
        death.clip = deathClip;
    }

    // Update is called once per frame
    void Update()
    {
        if (!juegoTerminado)
        {
            // Lógica de juego aquí...

            // Verificar si el juego debe terminar (por ejemplo, cuando la vida llega a cero)
            if (life.vida <= 0)
            {
                TerminarJuego();
            }
        }
    }
    void TerminarJuego()
    {
        juegoTerminado = true;
        gameOverCanvas.SetActive(true);
        //Destroy(player);
        player.enabled = false;
        player.enableMovementControl = false;
        player.enableCameraControl = false;
        StartCoroutine(FadeOut());
        //AudioListener.pause = true;
        IEnumerator FadeOut()
        {
            float startVolume = 1.0f;
            float timer = 0.0f;
            float fadeDuration = 0.1f;

            // Obtener todos los componentes AudioSource en la escena
            AudioSource[] allAudioSources = FindObjectsOfType<AudioSource>();

            // Filtrar solo los componentes AudioSource asociados al grupo "Player" en el Mixer
            foreach (AudioSource audioSource in allAudioSources)
            {
                AudioMixerGroup audioMixerGroup = audioSource.outputAudioMixerGroup;

                if (audioMixerGroup == playerMixer.FindMatchingGroups("Player")[0])
                {
                    while (timer < fadeDuration)
                    {
                        float volume = Mathf.Lerp(startVolume, 0, timer / fadeDuration);

                        // Ajustar gradualmente el volumen del AudioSource actual
                        audioSource.volume = volume;

                        timer += Time.deltaTime;
                        yield return null;
                    }

                    // Establecer el volumen del AudioSource actual en 0 al final del fade-out
                    audioSource.volume = 0;
                }
            }
            death.Play();
            


        }
         }
}
