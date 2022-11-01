using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CharacterMenu : MonoBehaviour
{
    //Text fields
    public Text levelText, hitpointText, pesosText, upgradeCostText, xpText;

    //Logic
    private int currentCharacterSelection = 0;
    public Image characterSelectionSprite;
    public Image weaponSprites;
    public RectTransform xpBar;

    //Character selection
    public void OnArrowClick(bool right)
    {
        if (right)
        {
            currentCharacterSelection++;

            //if we went to far
            if (currentCharacterSelection == GameManager.instance.playerSprites.Count)
                currentCharacterSelection = 0;

            OnSelectionChanged();
        }
        else
        {
            currentCharacterSelection--;

            //if we went to far
            if (currentCharacterSelection < 0)
                currentCharacterSelection = GameManager.instance.playerSprites.Count - 1;

            OnSelectionChanged();
        }
    }
    private void OnSelectionChanged()
    {
        characterSelectionSprite.sprite = GameManager.instance.playerSprites[currentCharacterSelection];
    }

    //Weapon upgrade
    public void OnUpgradeClick()
    {
        //
    }

    //Update character information
    public void UpdateMenu()
    {
        //Weapon
        weaponSprites.sprite = GameManager.instance.weaponSprites[0];
        upgradeCostText.text = "Not implemented";

        //Meta
        hitpointText.text = GameManager.instance.player.hitpoint.ToString();
        pesosText.text = GameManager.instance.pesos.ToString();
        levelText.text = "Not Implemented";

        //xp Bar
        xpText.text = "Not implemented";
        xpBar.localScale = new Vector3(0.5f, 0, 0);
    }
}
