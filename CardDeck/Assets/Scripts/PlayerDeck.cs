using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeck : MonoBehaviour
{

     public List<Card> deck = new List<Card>();
     public List<Card> container = new List<Card>();

     public int x;
     public int deckSize;

     public int count;
    // Start is called before the first frame update
    void Start()
    {
     x = 0;
     deckSize = 40;
     count = 0;

     for(int i = 0; i < deckSize; i++)
     {
        x = Random.Range(1,4);
        deck[i] = CardDataBase.cardList[x];
     }   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void Shuffle()
    {
        for(int i = 0; i < deckSize; i++)
        {
            container[0] = deck[i];
            int randomIndex = Random.Range(i, deckSize);
            deck[i] = deck[randomIndex];
            deck[randomIndex]  = container[0];
        }

        count++;
    }
}