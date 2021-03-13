using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject Enemy;
    private bool spawned = false;
    private void OnTriggerEnter(Collider other)
    {
        if (!spawned)
        {
            Instantiate(Enemy, transform.position, transform.rotation);
            spawned = true;
        }
    }

}
