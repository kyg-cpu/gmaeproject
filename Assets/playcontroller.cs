using JetBrains.Annotations;
using UnityEditor.U2D.Sprites;
using UnityEngine;


public class playcontroller : MonoBehaviour

{
    public float speed = 5f; //public = 외부 공용
    // Update is called once per frame
    public GameObject BulletPrefab;
    public float bulletSpeed = 100f;
    int[] scores = new int[5];
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < scores.Length; i++)
        {
            scores[i] = (i + 1) * 10;
        }

        Debug.Log(scores[0]);
        Debug.Log(scores[1]);
        Debug.Log(scores[2]);
        Debug.Log(scores[3]);
        Debug.Log(scores[4]);


    }
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(x, y, 0);
        transform.position += direction.normalized * speed * Time.deltaTime;

        if(Input.GetKeyDown(KeyCode.Space))
        {
            GameObject Bullet = Instantiate(BulletPrefab);
            Bullet.transform.position = transform.position;
            Bullet.GetComponent<Rigidbody2D>().AddForce(Vector2.up * bulletSpeed);
          
        }
        
    }
}
