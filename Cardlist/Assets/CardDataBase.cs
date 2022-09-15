using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDataBase : MonoBehaviour
{
    public static List<Card> cardList = new List<Card>();

    void Awake()
    {
        cardList.Add (new Card(0, "Nome", 0, 0, "Nome"));
        cardList.Add (new Card(1, "Elf", 2, 10, "Este é o Elf"));
        cardList.Add (new Card(2, "He-Man", 4, 1000, "Este é o He-Man"));
        cardList.Add (new Card(3, "Espinafre", 5, 100, "Este é o Espinafre"));
        cardList.Add (new Card(4, "July", 1, 500, "Esta é a July"));
        cardList.Add (new Card(5, "Torresmo", 3, 600, "Este é o Torresmo"));
    }
}
