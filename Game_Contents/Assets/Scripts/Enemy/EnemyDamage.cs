using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    [SerializeField] private float damage;

    protected void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player"){
            collision.GetComponent<Health>().TakeDamage(damage);
        }
        else if (collision.tag == "Player2")
        {
            collision.GetComponent<Health2>().TakeDamage(damage);
        }
    }
}