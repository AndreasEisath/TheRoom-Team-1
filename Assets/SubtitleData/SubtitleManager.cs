using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubtitleManager : MonoBehaviour
{
    public GameObject SubtitleParent;
    public TMPro.TMP_Text SubtitleUI;

    public void HideSubtitles() {
        SubtitleParent.SetActive(false);
    }
    public void ShowSubtitle(string subtitle)
    {
        SubtitleParent.SetActive(true);
        SubtitleUI.SetText(subtitle);
    }
    public void ShowSubtitlesWithDuration(string subtitle, float Duration)
    {
        SubtitleParent.SetActive(true);
        SubtitleUI.SetText(subtitle);
        StartCoroutine(HideSubtitles(Duration));
    }

    private IEnumerator HideSubtitles(float wait)
    {
        yield return new WaitForSeconds(wait);
        SubtitleParent.SetActive(false);
    }
}
