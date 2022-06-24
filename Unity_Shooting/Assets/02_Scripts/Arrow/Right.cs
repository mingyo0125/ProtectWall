using UnityEngine;

public class Right : MonoBehaviour
{
    public float speed = 3f;

    public float damage;
    void Update()
    {
        Vector3 dir = Vector3.right;
        transform.position += speed * dir * Time.deltaTime;      
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            gameObject.SetActive(false);
            other.GetComponent<EnemyHp>().TakeDamage(damage);
        }
    }
}
