using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    public GameObject lights;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToggleLights() {
        lights.SetActive(!lights.activeSelf);
        lights.transform.Rotate(Vector3.forward, 180);
    }
}
