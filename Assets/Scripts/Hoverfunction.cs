using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Hoverfunction : MonoBehaviour
{
    public GameObject HoverPanel;
    public void OnHoverStart()
    {
        HoverPanel.SetActive(true);
    }

    public void OnHoverExit()
    {
        HoverPanel.SetActive(false);
    }
}
