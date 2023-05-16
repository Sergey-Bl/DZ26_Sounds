using System;
using UnityEngine;
using UnityEngine.Audio;

namespace NickKhalow.Sound_Managments.Scripts.UI
{
    public class ChangerVolume : MonoBehaviour
    {
        [SerializeField]private AudioMixer audioMixer;

        public void SetVolume(float volume)
        {
            audioMixer.SetFloat("volume", Mathf.Log10(volume) * 20);
        }
    }
}