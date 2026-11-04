
using UnityEngine;

public class Enemy_test : MonoBehaviour
{
    float health = 50f;

    public float speed;

    // 체력 읽기 전용 프로퍼티
    public float Health
    {
        get { return health; }
    }

    // 데미지 처리
    private void TakeDamage(int value)
    {
        health -= value;

        if (health <= 0)
        {
            Die();
        }
    }

    // 충돌 감지
    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag("Bullet"))
        {
            TakeDamage(10);

            Debug.Log("Health : " + health);

            coll.gameObject.SetActive(false);
        }
    }

    // 사망 처리
    void Die()
    {
        Destroy(this.gameObject);
    }

    void Start()
    {
    }

    void Update()
    {
    }
}
