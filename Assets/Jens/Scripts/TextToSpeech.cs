using System.Collections;
using System.Collections.Generic;
using SpeechLib;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class TextToSpeech : MonoBehaviour
{
    void Start()
    {
        SpVoice voice;
        voice = new SpVoice();
        voice.Speak("yo yo yo I go with the flow, and your mum is a ho.");
    }
}
