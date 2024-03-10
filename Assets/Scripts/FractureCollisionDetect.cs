using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FractureCollisionDetect : MonoBehaviour
{
    public float minCollisionForce;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        float collisionForce = (collision.impulse / Time.fixedDeltaTime).magnitude;
        if (collisionForce >= minCollisionForce)
        {
            GetComponent<Fracture>().CauseFracture();
        }
    }
}
