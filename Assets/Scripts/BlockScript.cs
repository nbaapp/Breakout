using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockScript : MonoBehaviour
{
    public SpriteRenderer MySpriteRenderer;
    public Sprite Health4;
    public Sprite Health3;
    public Sprite Health2;
    public Sprite Health1;
    public int health = 4;

    // Start is called before the first frame update
    void Start()
    {
        if (health == 4)
        {
            MySpriteRenderer.sprite = Health4;
        }
        else if (health == 3)
        {
            MySpriteRenderer.sprite = Health3;
        }
        else if (health == 2)
        {
            MySpriteRenderer.sprite = Health2;
        }
        else if (health == 1)
        {
            MySpriteRenderer.sprite = Health1;
        }
        else if (health == 0)
        {
            Destroy(gameObject);
        }
        else
        {
            MySpriteRenderer.sprite = Health4;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        health -= 1;
        if (health == 4)
        {
            MySpriteRenderer.sprite = Health4;
        }
        else if (health == 3)
        {
            MySpriteRenderer.sprite = Health3;
        }
        else if (health == 2)
        {
            MySpriteRenderer.sprite = Health2;
        }
        else if (health == 1)
        {
            MySpriteRenderer.sprite = Health1;
        }
        else if (health == 0)
        {
            Destroy(gameObject);
        }
        else
        {
            MySpriteRenderer.sprite = Health4;
        }
    }
}
