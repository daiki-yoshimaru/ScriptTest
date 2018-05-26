
using UnityEngine;
using System.Collections;
public class Test : MonoBehaviour {
    void Start () { 
    
        int[] array = {60, 70, 40, 50, 80};
        for (int i = 4; i >= 0; i--)
        {
                Debug.Log (array [i]);
            }

        }

    


    // Update is called once per frame
    void Update()
    {

    }
}