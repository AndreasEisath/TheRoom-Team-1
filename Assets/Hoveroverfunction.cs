using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hoveroverfunction : MonoBehaviour
{
    public GameObject popup;
        
    public void onhoverstart()
    {
        popup.SetActive(true);
    }

    public void onhoverend()
    {
        popup.SetActive(false);
    }
}
