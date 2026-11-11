using UnityEngine;

class Animal
{
    public void Move()
    {
        Debug.Log("move");
    }
    public void Eat()
    {
        Debug.Log("eat");
    }
}
class Bird : Animal
{ }
class Fish : Animal
{ }

public class human : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //human Paul = new human("paul", 3, 90);
        //Baby baby = Paul as baby;

        //if (baby == null)
        //{
        //    Debug.Log("형변환 실패");
        //}
        //else
        //{
        //    Debug.Log("형변환 성공");
        //}
        Bird eagle = new Bird();
        Fish shark = new Fish();
        eagle.Move();
        shark.Move();
    }

    abstract class Animal
    {
        public abstract void Move();
        public void Eat()
        {
            Debug.Log("eat");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
