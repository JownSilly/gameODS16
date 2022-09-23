using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardController : MonoBehaviour
{
    public List<Card> cardController;
    public List<ShowCard> allCards;

    public void GetCard(int optionSelected)
    {
        Card selectedCard = cardController[optionSelected];
        allCards[0].exibeCarta(selectedCard);
        //fazer o random e enviar o indice para outro array para uso no resgate de cartas
    }
}
