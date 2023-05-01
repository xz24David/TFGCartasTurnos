using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{
    public Card card;

    public Text nameText, EffectText, CostText;
    public Image artworkImagen;

    // Start is called before the first frame update
    void Start()
    {
       /* nameText.text = card.name;
        EffectText.text = card.descrption;
        CostText.text = card.cost;
        artworkImagen.sprite = card.artwork;*/

        Debug.Log(card.name);
    }

}
