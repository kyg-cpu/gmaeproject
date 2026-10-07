using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class side : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 1; i < 4; i++)
        {
            Debug.Log(i);
        }
    }
    //{
    //    int a = 1;
    //    switch(a)
    //    {
    //        case < 3:
    //            Debug.Log("a가 3보다 작다");
    //            break;

    //        case > 3:
    //            Debug.Log("a가 3보다 크다");
    //            break;

    //        default:
    //            Debug.Log("a는 3이다");
    //            break;
    //    }
    //}
    //{
    //    int a = 6;
    //    if (a <= 6)
    //    {
    //        Debug.Log(a);
    //    }
    //else
    //    {
    //        Debug.Log("6보다 크거나 같지 않다.");
    //    }
    //}

    // Update is called once per frame
    void Update()
    {
        
    }
}
