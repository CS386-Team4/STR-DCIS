using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenChestScript : MonoBehaviour
{
    SpriteRenderer mySpriteRenderer;

    void Start()
    {
        mySpriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        string spriteName = col.gameObject.GetComponent<SpriteRenderer>().sprite.name;

        mySpriteRenderer.sprite = (Sprite)Resources.Load("Sprites/TreasureOpen") as Sprite;
    }
}
