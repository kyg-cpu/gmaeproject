
using UnityEngine;

public class BirdTest : MonoBehaviour
{
    // Start is called once before the first execution of Update
    void Start()
    {
        Bird eagle = new Bird();
        Fish shark = new Fish();

        eagle.Move();
        shark.Move();
    }

    // Update is called once per frame
    void Update()
    {

    }
}

