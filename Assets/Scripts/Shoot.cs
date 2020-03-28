using System.Collections;
using System.Collections.Generic;
using UnityEngine.Networking;
using UnityEngine;

[System.Obsolete]
public class Shoot : NetworkBehaviour
{
    public GameObject projectile;
    public float force = 30;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!isLocalPlayer)
        {
            // exit from update if this is not the local player
            return;
        }

        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            GameObject clone;
            // Instantiate the projectile at the position and rotation of this transform
            clone = Instantiate(projectile, transform.position + transform.forward * 2, transform.rotation);

            // Give the cloned object an initial velocity along the current
            // object's Z axis
            clone.GetComponent<Rigidbody>().velocity = transform.TransformDirection(Vector3.forward * force);
            Destroy(clone, 5);
        }
            
    }
}
