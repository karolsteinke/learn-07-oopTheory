using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    void Start() {
        Item item1 = new Item("pen", 1);
        Item item2 = new Item("dogo", 10);
        Item item3 = new Item("lamp", 20);
        
        LightBox lightbox1 = new LightBox();
        HeavyBox heavyBox1 = new HeavyBox(3);

        lightbox1.Add(item1);
        heavyBox1.Add(item2);
        heavyBox1.Add(item3);

        Debug.Log("is item1 in lightbox1? " + lightbox1.IsInBox(item1));
        Debug.Log("is item1 in heavybox1? " + heavyBox1.IsInBox(item1));
        Debug.Log("is item2 in heavybox1? " + heavyBox1.IsInBox(item2));
    }
}
