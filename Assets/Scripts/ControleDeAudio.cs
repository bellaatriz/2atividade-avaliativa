using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class ControleDeAudio : MonoBehaviour
{
    public int volume;
    public int volumeSFX;
    public bool musica;
    
    public Slider volumeSlider;
    public Slider volumeSFXSlider; 
    public Toggle toggleMusica;
    
    void Start()
    {
        musica = toggleMusica.isOn;
        volume = (int)volumeSlider.value;
    }

   
    void Update()
    {
        
    }
}
