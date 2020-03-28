using System.Collections;
using System.Collections.Generic;
using UnityEngine.Networking;
using UnityEngine;

[System.Obsolete]
public class CameraPositionUpdate : MonoBehaviour
{
    public Transform player;
    Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.position;
    }

    public void Update()
    {
        //if (!isLocalPlayer)
        //{
        //    // exit from update if this is not the local player
        //    return;
        //}

        offset = transform.position - player.position;
        transform.position = player.position + offset;
    }

    private void FixedUpdate()
    {
        offset = transform.position - player.position;
        transform.position = player.position + offset;
        //GameObject Player = GameObject.FindWithTag("Player");
        //GameObject MainCam = GameObject.FindWithTag("MainCamera");
        //MainCam.transform.position = Player.transform.position + new Vector3(0, 10, 0);
    }
}
