using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hoveroverfunction : MonoBehaviour
{
    public GameObject popup;
        
    public void onhoverstart()
    {
        if(popup) popup.SetActive(true);
    }

    public void onhoverend()
    {
        if(popup) popup.SetActive(false);
    }

    public void HoverToggle()
    {
        if(popup) popup.SetActive(!popup.activeSelf);
    }
}
