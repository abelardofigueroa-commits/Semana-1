using UnityEngine;

public class teoria1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PokemonA charmander = new PokemonA();
        charmander.PokemonName = "charmander";
        charmander.Atk = 6;
        charmander.Vit = 7;
        charmander.Type = PokemonType.Fuego;


        PokemonA squirtle = new PokemonA();
        squirtle.PokemonName = "squirtle";
        squirtle.Atk = 5;
        squirtle.Vit = 4;
        squirtle.Type = PokemonType.Agua;

        PokemonA chikorita = new PokemonA();
        chikorita.PokemonName = "chikorita";
        chikorita.Atk = 5;
        chikorita.Vit = 8;
        chikorita.Type = PokemonType.Planta;

        charmander.Introductión();
        squirtle.Introductión();
        chikorita.Introductión();
    }
}
public enum PokemonType
{
    Planta,//->0
    Fuego,//->1
    Agua,//->2
}

public class PokemonA
{
    //->Atributos
    public string PokemonName;
    public int Atk;
    public int Vit;
    public PokemonType Type;

    //->Metodos o comportamiento
    public void Introductión()
    {
        Debug.Log("Soy" + PokemonName
            + "\n Mis puntos de ataque son: " + Atk
            + "\n Mis puntos de defendsa son: " + Vit
            + "\n Soy de tipo: " + Type.ToString());
    }
}