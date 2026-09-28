using UnityEngine;

public class Coin
{
    public string name;
    public int value;

    public Coin(string name, int value)
    {
        this.name = name;
        this.value = value;
    } 
    public int GetValue()
    {
        return value;
    }
    public string GetName()
    {
        return name;
    }
}
