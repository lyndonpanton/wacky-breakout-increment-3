using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandardBlock : Block
{
    [SerializeField]
    Sprite[] standardBlocks;


    // Start is called before the first frame update
    void Start()
    {
        PointsWorth = ConfigurationUtils.StandardBlockPoints;

        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();

        int options = standardBlocks.Length;

        spriteRenderer.sprite = standardBlocks[Random.Range(0, options)];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
