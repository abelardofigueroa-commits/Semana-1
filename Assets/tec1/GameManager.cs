using UnityEngine;
using UnityEngine.LowLevel;

public class Game : MonoBehaviour
{
    void Start()
    {
        NPC Hercules = new NPC ("Juan", 0, 100);
        NPC Demonio = new NPC("Demonio", 50, 200);

        for (int i = 0; i < 5; i++) 
        {
            new NPC("NPC " + i, Random.Range(1, 100), Random.Range(50, 200));
        }
     
    }

    void Update()
    {
        float damageProp = Random.Range(-1.0f, 1.0f);

    }
}
