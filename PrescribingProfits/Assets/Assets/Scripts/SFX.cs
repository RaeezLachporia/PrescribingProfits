using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFX : MonoBehaviour
{
    public IDictionary<string, AudioClip> soundEffect = new Dictionary<string, AudioClip>();

    static SFX sfx;
    [SerializeField] AudioSource source;
    [SerializeField] List<AudioClip> sounds = new List<AudioClip>();

    void Awake()
    {
        sfx = this;

        soundEffect.Add("VoiceOne", sounds[0]);
        soundEffect.Add("VoiceTwo", sounds[1]);
        soundEffect.Add("VoiceThree", sounds[2]);
        soundEffect.Add("VoiceFour", sounds[3]);
        soundEffect.Add("VoiceFive", sounds[4]);
        soundEffect.Add("VoiceSix", sounds[5]);
        soundEffect.Add("VoiceSeven", sounds[6]);
        soundEffect.Add("VoiceEight", sounds[7]);
        soundEffect.Add("VoiceNine", sounds[8]);

        soundEffect.Add("PhoneRining", sounds[9]);
        soundEffect.Add("PhoneDialing", sounds[10]);
    }

    public void PlaySound(string soundName)
    {
        source.PlayOneShot(soundEffect[soundName]);
    } 
}
