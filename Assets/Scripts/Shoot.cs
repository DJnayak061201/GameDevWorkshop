using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Camera cam;
    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Input.GetButtonDown("Fire1"))
        {
            
            if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit))
            {
                if (hit.collider.tag == "enemy")
                {
                    Destroy(hit.collider.gameObject);
                }
            }
        }
    }
}
