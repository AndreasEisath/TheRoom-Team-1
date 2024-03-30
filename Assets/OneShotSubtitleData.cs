using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneShotSubtitleData : MonoBehaviour
{

    [TextArea]
    public string subtitle;
    public AudioClip subtitledAudio;
    public SubtitleManager subtitleManager;
    // Start is called before the first frame update
    void Start()
    {
        if (!subtitleManager)
        {
            subtitleManager = FindObjectOfType<SubtitleManager>();
        }
        if (!subtitledAudio)
        {
            Debug.LogError("No audio clip given, default to 1 second");
        }
    }
    private float getAudioDuration()
    {
        if (subtitledAudio)
            return subtitledAudio.length;
        else
            return 1.0f;
    }
    public void StartSubtitle()
    {
        subtitleManager.ShowSubtitlesWithDuration(subtitle, getAudioDuration());
    }
}
