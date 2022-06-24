using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float speed = 5f;

    public float damage = 1;

    void Update()
    {
        Vector3 dir = Vector3.left;
        transform.position += dir * speed * Time.deltaTime;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            other.GetComponent<PlayerHP>().TakeDamage(damage);
            gameObject.SetActive(false);
        }
    }
}
