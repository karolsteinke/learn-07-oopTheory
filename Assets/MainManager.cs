using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    void Start() {
        Item item = new Item("pen", 1);
        
        Debug.Log("I've got one item, it weights: " + item.GetWeight());
    }
}
