using UnityEngine;

public class practice : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    void Start()
//    {
//        int[] numbers = { 1, 2, 3, 4, 5 };
//        for(int i = 0; 1 < numbers.Length; i++)
//        {
//            Debug.Log(numbers[i]);
//        }
//    }

//    // Update is called once per frame
//    void Update()
//    {

//    }
//}
//{
//    void Start()
//    {
//        int[] numbers = { 1, 2, 3, 4, 5 };
//        foreach (int item in numbers)
//        {
//            Debug.Log(item);
//        }
//    }
//    void Update()
//    {

//    }
//}
//{
//    void Start()
//    {
//        int i = 1;
//        while (i < 6)
//        {
//            Debug.Log(i);
//            i++;
//        }
//    }
//}
//{
//    void Start()
//    {
//        int j = 1;
//        while (true)
//        {
//            if (j > 5)
//            {
//                break;
//            }
//            Debug.Log(j);
//            j++;
//        }
//    }
//}

{
    void start()
    {
        int k = 1;
        while (k <= 10)
        {
            if (k % 2 == 0)
            {
                k ++;
                  continue;
            }
            Debug.Log(k);
            k++;
        }
    }
}