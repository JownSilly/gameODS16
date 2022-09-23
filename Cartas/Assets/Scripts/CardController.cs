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
        //se usuario escolher a carta, enviar seu indice para outro array para uso no resgate de cartas
        //se o usuário recusar a carta, manter o indice no array (ou em outro com possibilidade de reaver)
    }
}
