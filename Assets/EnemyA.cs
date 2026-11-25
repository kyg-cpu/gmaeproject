
using UnityEngine;

public class EnemyA : Enemy_test
{
    [Header("Movement")]
    public float fallSpeed = 2f;
    public float moveSpeed = 2f;

    [Header("Screen Boundary")]
    public float minX = -2.5f;
    public float maxX = 2.5f;
    public float destroyY = -5.5f;

    [Header("Random Direction")]
    public float changeTime = 1.5f;

    private int direction;
    private float timer;

    void Start()
    {
        // 처음 이동 방향 랜덤 설정
        direction = Random.Range(0, 2) == 0 ? -1 : 1;
    }

    void Update()
    {
        // 아래로 떨어지기
        transform.Translate(
            Vector2.down * fallSpeed * Time.deltaTime,
            Space.World
        );

        // 좌우 이동
        transform.Translate(
            Vector2.right * direction * moveSpeed * Time.deltaTime,
            Space.World
        );

        // 좌우 경계 도달 시 방향 반전
        float x = transform.position.x;

        if (x >= maxX)
        {
            direction = -1;
            x = maxX;
        }
        else if (x <= minX)
        {
            direction = 1;
            x = minX;
        }

        transform.position = new Vector3(
            x,
            transform.position.y,
            transform.position.z
        );

        // 일정 시간마다 랜덤 방향 변경
        timer += Time.deltaTime;

        if (timer >= changeTime)
        {
            direction = Random.Range(0, 2) == 0 ? -1 : 1;
            timer = 0f;
        }

        // 화면 아래로 나가면 삭제
        if (transform.position.y < destroyY)
        {
            Destroy(gameObject);
        }
    }
}
