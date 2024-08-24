using UnityEditor;
using UnityEngine;
using UnityEngine.Audio;

public class FiltroLow : MonoBehaviour





{
    public AudioMixer audioMixer; // Referencia al Audio Mixer que controla el canal maestro.
    public string parametroFiltro = "FiltroPasoBajo"; // Nombre del parámetro del filtro en el Audio Mixer.
    public float frecuenciaCorteInicial = 500f; // Frecuencia de corte inicial del filtro.
    public float frecuenciaCorteFinal = 22000f; // Frecuencia de corte final del filtro.
    public float velocidadCambio = 1f; // Velocidad de cambio del filtro.

    private float tiempoInicio;
    private bool aplicarFiltro = false;

    void Start()
    {
        tiempoInicio = Time.time;
    }

    void Update()
    {
        if (aplicarFiltro)
        {
            float tiempoTranscurrido = Time.time - tiempoInicio;
            float nuevaFrecuenciaCorte = Mathf.Lerp(frecuenciaCorteInicial, frecuenciaCorteFinal, tiempoTranscurrido * velocidadCambio);

            // Aplicar la frecuencia de corte al parámetro del filtro en el Audio Mixer.
            audioMixer.SetFloat(parametroFiltro, nuevaFrecuenciaCorte);
        }
        else
        {
            float tiempoTranscurrido = Time.time - tiempoInicio;
            float nuevaFrecuenciaCorte = Mathf.Lerp(frecuenciaCorteInicial, frecuenciaCorteFinal, tiempoTranscurrido * velocidadCambio);

            // Aplicar la frecuencia de corte al parámetro del filtro en el Audio Mixer.
            audioMixer.SetFloat(parametroFiltro, 22000f);
        }

    }

    public void ActivarFiltro()
    {
        aplicarFiltro = true;
    }

    public void DesactivarFiltro()
    {
        aplicarFiltro = false;
    }
}