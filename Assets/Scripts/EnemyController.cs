using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public HealthBar healthBar;
    public float Health;
    public GameObject ShatteredEnemy;

    private void Start()
    {
        healthBar.SetMaxHealth(Health);
    }

    public void TakeDamage(float Damage, Vector3 hitpt)
    {
        if (Health > Damage)
        {
            Health -= Damage;
            healthBar.SetHealth(Health);
        }
        else
        {
            Death(hitpt);
        }
    }

    void Death(Vector3 hitpt)
    {
        GameObject s = Instantiate(ShatteredEnemy, transform.position, transform.rotation);
        s.GetComponent<Shatter>().ShatterObject(hitpt);
        Destroy(gameObject);
    }
}
