using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public GameObject hitEffect;

    void OnCollisionEnter(Collision collider)
	{
        GameObject effect = Instantiate(hitEffect, transform.position, transform.rotation);
        Destroy(effect, 2);
        Destroy(gameObject);

	}
}
