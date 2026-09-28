using UnityEngine;

public class NPC : MonoBehaviour
{
    public string Name;
    public int Level;
    public int Health;
    int x, y; // position
    void Start()
    {
        DisplayInfo();
        int x = 0;
        int y = 0;
    }

    private void Update()
    {
        x += Random.Range(-1, 1);
        y += Random.Range(-1, 1);
    }

    public NPC(string name, int level, int health)
    {
        Name = name;
        Level = level;
        Health = health;
    }

    public void DisplayInfo()
    {
        Debug.Log("Player Name: " + Name);
        Debug.Log("Level: " + Level);
        Debug.Log("Health: " + Health);
    } 
    public void TakeDamage(int damage)
    {
        Health -= damage;
        if (Health < 0)
        {
        Health = 0;
        }
        Debug.Log(Name + " took " + damage + " damage. Remaining health: " + Health);
    }
    public void Heal(int amount)
    {
        Health += amount;
        Debug.Log(Name + " healed " + amount + " health. Current health: " + Health);
    }
    public string GetName()
    {
        return Name;
    }
    public int GetLevel()
    {
        return Level;
    }
    public int GetHealth()
    {
        return Health;
    }
}

