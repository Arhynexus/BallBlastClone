using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float lifeTime;
    [SerializeField] private int damage;
    void Start()
    {
        Destroy(gameObject, lifeTime);
    }


    void Update()
    {
        transform.position += transform.up * speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destructible destructible = collision.transform.root.GetComponent<Destructible>();
        if (destructible != null)
        {
            destructible.ApplyDamage(damage);
            Destroy(gameObject);
        }
    }
}
