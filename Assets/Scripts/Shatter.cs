using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shatter : MonoBehaviour
{
    public float ExplosionForce;
    public float ExplosionRadius;
    public void ShatterObject(Vector3 hitpt)
    {
        Rigidbody[] rbs = GetComponentsInChildren<Rigidbody>();
        foreach(Rigidbody rb in rbs)
        {
            rb.AddExplosionForce(ExplosionForce, hitpt, ExplosionRadius);
        }
        Destroy(gameObject, 3);
    }
}
