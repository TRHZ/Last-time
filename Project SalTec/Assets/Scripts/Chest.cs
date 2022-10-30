using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : Collectable
{
    public Sprite emptyChest;
    public int pesosAmount = 5;

    protected override void OnCollect()
    {
        if (!collected)
        {
            collected = true;
            GetComponent<SpriteRenderer>().sprite = emptyChest;
            //string msg, int fontSize, Color color, Vector3 position, Vector3 motion, float duration
            //GameManager.instance.ShowText("+ " + pesosAmount + "pesos!", 60, Color.yellow, transform.position, Vector3.up * 50, 3.0f);
        }
    }
}
