using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDataBase : MonoBehaviour
{
    public static List<Card> cardList = new List<Card>();

    void Awake()
    {
        // int Id, string CardName, int Cost, int Power, string CardDescription, Sprite Image, Color)
        cardList.Add (new Card(0, "None", 0, 0,"None", Resources.Load<Sprite>("download"), "None" ));
        cardList.Add (new Card(1, "Carta 1", 1200, 4, "Esta é a Carta 1", Resources.Load<Sprite>("download"), "Red" ));
        cardList.Add (new Card(2, "Carta 2", 100, 2, "Esta é a Carta 2", Resources.Load<Sprite>("download"), "Blue" ));
        cardList.Add (new Card(3, "Carta 3", 20000, 10, "Esta é a Carta 3", Resources.Load<Sprite>("download"), "Yellow" ));
        cardList.Add (new Card(4, "Carta 4", 200, 3, "Esta é a Carta 4", Resources.Load<Sprite>("download"), "Purple" ));
    }
}
