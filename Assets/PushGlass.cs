using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushGlass : MonoBehaviour
{
    private bool hasBeenTriggered = false;
    public Rigidbody impulseTarget;
    public GameObject direction;
    public float force = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (hasBeenTriggered) return;
        Debug.Log("Triggered glass");
        hasBeenTriggered = true;
        Vector3 impulseDirection = direction.transform.position - impulseTarget.transform.position;
        impulseTarget.AddForce(Vector3.Normalize(impulseDirection) * force);
    }
}
