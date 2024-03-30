using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class SubtitleData : MonoBehaviour
{
    public SubtitleManager subtitleManager;
    [TextArea]
    public List<string> subtitleText = new(1);
    public PlayableDirector director;
    private int index = -1;
    // Start is called before the first frame update
    void Start()
    {
        if(subtitleManager == null)
        {
            subtitleManager = Object.FindObjectOfType<SubtitleManager>();
        }
        if(director == null)
        {
            director = GetComponent<PlayableDirector>();
        }
    }

    public void ToggleSubtitles()
    {
        if(director.state == PlayState.Playing)
        {
            director.Stop();
            ResetSubtitle(true);
            return;
        }
        director.Play();
    }
    public void ResetSubtitle(bool reset)
    {
        if (reset) index = -1;
        subtitleManager.HideSubtitles();
        GetComponent<PlayableDirector>().Stop();
    }
    public void TickSubtitle()
    {
        index += 1;
        if (index >= subtitleText.Count)
        {
            // No more subtitles, disable and stop
            ResetSubtitle(true);
            return;
        }
        string currentSubs = subtitleText[index];
        subtitleManager.ShowSubtitle(currentSubs);
    }
}
