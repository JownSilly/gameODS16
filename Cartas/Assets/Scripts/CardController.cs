using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardController : MonoBehaviour
{
    public List<Card> cardController;
    public List<ShowCard> allCards;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetCard(int optionSelected)
    {
        Card selectedCard = cardController[optionSelected];
        allCards[0].exibeCarta(selectedCard);
    }
}
