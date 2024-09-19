using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlFlow : MonoBehaviour
{
    // Start is called before the first frame update
    public bool flag;

    void Start()
    {
      if(flag)
      {
        Debug.Log("Boolean flag is set");
      }  
      else 
      {
        Debug.Log("Boolean flag isn't set");
      }
    
        for (int i = 1; i <= 10; i++)

        {
            float powerValue = Mathf.Pow(2, i);
            Debug.Log($"The {i} power of 2 is{powerValue}");
        }

    }
    // Update is called once per frame
  
}
