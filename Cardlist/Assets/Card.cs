using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class Card : MonoBehaviour
{
    public int id;
    public string cardName;
    public int cost;
    public int power;
    public string cardDescription;

    // Start is called before the first frame update
    public Card()
    {
        
    }

    public Card(int ID, string CardName, int Cost, int Power, string CardDescription)
    {
        id = ID;
        cardName = CardName;
        cost = Cost;
        power = Power;
        cardDescription = CardDescription;
    }
}
