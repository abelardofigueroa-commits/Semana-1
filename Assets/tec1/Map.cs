using UnityEngine;
using System.Collections.Generic;

public class Map : MonoBehaviour
{
    void Start()
    {

        List<char> list = new List<char>();
        char[] objects = { 'A', 'B', 'C', 'D', 'E' };
        list.AddRange(objects);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
