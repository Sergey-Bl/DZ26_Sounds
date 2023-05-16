using UnityEngine;

namespace UI
{
    public class MainMenu : MonoBehaviour
    {
        public AudioSource audio;

        public void playButton()
        {
            audio.Play();
        }
    }
}