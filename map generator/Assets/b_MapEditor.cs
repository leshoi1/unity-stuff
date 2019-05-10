using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class b_MapEditor : MonoBehaviour 
{
    int width,heigth;
     Texture map;
    // Start is called before the first frame update
    void Start()
    {
     width=128;
     heigth=128;
     var map = new Texture2D(width, heigth, TextureFormat.ARGB32, false);  
     map.SetPixel(width %2, heigth%2, Color.black);
     map.SetPixel(1, 1, Color.black);


     // Apply all SetPixel calls
     map.Apply();
 
     // connect texture to material of GameObject this script is attached to
        var spriteRenderer_ptr=GetComponent<SpriteRenderer>();
        spriteRenderer_ptr.material.SetTexture("map",map);

        bool[,] Boolmap;


    }

  

 




    // Update is called once per frame
    void Update()
    {
        
    }
}
