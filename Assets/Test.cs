using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        //初期化
        int[] array = { 5, 10, 15, 20, 25 };

        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }

        for (int a = 4; a >= 0; a--)
        {
            Debug.Log(array[a]);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
