using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWithKeys : MonoBehaviour
{
    public float Stepsize = 0.1F;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Vector3 position = this.transform.position;
            position.x = position.x - Stepsize;
            this.transform.position = position;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Vector3 position = this.transform.position;
            position.x = position.x + Stepsize;
            this.transform.position = position;
        }

        //if (Input.GetKeyDown(KeyCode.LeftArrow))
        //{
        //    Vector3 position = this.transform.position;
        //    position.x = position.y - Stepsize;
        //    this.transform.position = position;
        //}
        //if (Input.GetKeyDown(KeyCode.RightArrow))
        //{
        //    Vector3 position = this.transform.position;
        //    position.x = position.y + Stepsize;
        //    this.transform.position = position;
        //}
        //if (Input.GetKeyDown(KeyCode.UpArrow))
        //{
        //    Vector3 position = this.transform.position;
        //    position.z = position.z + Stepsize;
        //    this.transform.position = position;
        //}
        //if (Input.GetKeyDown(KeyCode.DownArrow))
        //{
        //    Vector3 position = this.transform.position;
        //    position.z = position.z - Stepsize;
        //    this.transform.position = position;
        //}
    }

}

