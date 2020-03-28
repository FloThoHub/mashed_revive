using System.Collections;
using System.Collections.Generic;
using UnityEngine.Networking;
using UnityEngine;
using UnityEngine.UI;

[System.Obsolete]
public class PlayerStats : NetworkBehaviour
{
    public int hitpoints = 100;
    public GameObject hitpoints_text;
    // Start is called before the first frame update
    void Start()
    {
        hitpoints_text.GetComponent<Text>().text = hitpoints.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isLocalPlayer)
        {
            // exit from update if this is not the local player
            return;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Projectile")
        {
            hitpoints = hitpoints - 10;
            hitpoints_text.GetComponent<Text>().text = hitpoints.ToString();
            Destroy(collision.gameObject);
        }
           
    }
}
