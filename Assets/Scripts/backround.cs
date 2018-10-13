using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backround : MonoBehaviour
{

    public Texture2D background;

    private int drawDepth = 2;

    void Start()
    {
        Resize();
    }

    void Resize()
    {
        BoxCollider2D sr = GetComponent<BoxCollider2D>();
        if (sr == null) return;

        transform.localScale = new Vector3(1, 1, 1);

        float width = sr.size.x;
        float height = sr.size.y;


        float worldScreenHeight = Camera.main.orthographicSize * 2f;
        float worldScreenWidth = worldScreenHeight / Screen.height * Screen.width;

        Vector3 xWidth = transform.localScale;
        xWidth.x = worldScreenWidth / width;
        transform.localScale = xWidth;
        //transform.localScale.x = worldScreenWidth / width;
        Vector3 yHeight = transform.localScale;
        yHeight.y = worldScreenHeight / height;
        transform.localScale = yHeight;
        //transform.localScale.y = worldScreenHeight / height;

    }
}
