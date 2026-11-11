using UnityEngine;

public class Player : MonoBehaviour
{
    float health = 100.0f; //플레이어 체력

    private void TakeDamage(int value)
    {
        health -= value;

        if (health <= 0)
        {
            Die();
        }
        Debug.Log("Enemy Health : " + health);
    }

    

    void Die()
    {
        Destroy(this.gameObject);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        TakeDamage(20);
        Destroy(collision.gameObject);

        Debug.Log("Player Health : " + health);

    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
