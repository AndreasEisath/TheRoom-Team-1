using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubtitleData : MonoBehaviour
{
    public SubtitleManager subtitleManager;
    [TextArea]
    public List<string> subtitleText = new(1);
    private int index = -1;
    // Start is called before the first frame update
    void Start()
    {
        if(subtitleManager == null)
        {
            subtitleManager = Object.FindObjectOfType<SubtitleManager>();
        }
    }

    public void ResetSubtitle(bool reset)
    {
        if (reset) index = -1;
        subtitleManager.HideSubtitles();
    }
    public void TickSubtitle()
    {
        index += 1;
        if (index > subtitleText.Count)
        {
            // No more subtitles, disable and stop
            ResetSubtitle(true);
            return;
        }
        string currentSubs = subtitleText[index];
        subtitleManager.ShowSubtitle(currentSubs);
    }
}
