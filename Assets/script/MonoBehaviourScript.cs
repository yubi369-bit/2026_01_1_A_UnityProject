using System.Collections.Generic;
using UnityEngine;

public class MonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[] testArray = new int[10];






        //01234
      
        for(int i =0 ; i <10; i++ )
        {
            testArray[i] = 10 + i;
            
            Debug.Log (testArray[i]);
        }

        List<int> testList = new List<int>();


        testList. Add(15);

        testList[0] = 15;

        Debug.Log (testList[4]);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * 0.03f;
        }


    }
}
