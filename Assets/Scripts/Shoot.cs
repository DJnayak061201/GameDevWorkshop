using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Camera cam;
    public LayerMask EnemyLayer;
    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Input.GetButtonDown("Fire1"))
        {
            
            if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, 100f, EnemyLayer))
            {
                if (hit.collider.tag == "enemy")
                {
                    hit.collider.gameObject.GetComponent<EnemyController>().TakeDamage(20, hit.point);
                }
            }
        }
    }
}
