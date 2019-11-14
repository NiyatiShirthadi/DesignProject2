using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapSprite : MonoBehaviour
{
    public Sprite blackSprite;
    public Sprite glowySprite;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = blackSprite;

        CreateTheBlackness.letThereBeDark += ActivateTheGlow;
    }

    public void ActivateTheGlow()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = glowySprite;
    }

    private void OnDisable()
    {
        CreateTheBlackness.letThereBeDark -= ActivateTheGlow;
    }
}
