using UnityEngine;

public class human : MonoBehaviour
{
    private void Start()
    {
        Adult john = new Adult("john", 28, 173);
        Baby lisa = new Baby("lisa", 3, 95);

        Debug.Log(john.age);
        lisa.Sleep();
    }
}

//class Human
//{
//    public string name;
//    public int age;
//    public float height;
//    protected string address;

//    public string Name
//    {
//        get { return name; }
//        set { name = value; }
//    }
//    public int Age
//    {
//        get { return age; }
//        set { age = value; }
//    }
//    public float Height
//    {
//        get { return height; }
//        set { height = value; }
//    }
//    public int GetAge()
//    {
//        return age;
//    }

//    public void SetAge(int _age)
//    {
//        age = _age;
//    }
//    public Human()
//    {

//    }

//    public Human(string _name, int _age, float _height)
//    {
//        name = _name;
//        age = _age;
//        height = _height;
//    }
//    public void Eat()
//    {
//        Debug.Log("eat");
//    }

//    public virtual void Walk()
//    {
//        Debug.Log("walk");
//    }
//}

class Adult : Human
{
    public Adult(string _name, int _age, float _height) : base(_name, _age, _height) { }
}

class Baby : Human
{
    public Baby(string _name, int _age, float _height) : base(_name, _age, _height) { }
}