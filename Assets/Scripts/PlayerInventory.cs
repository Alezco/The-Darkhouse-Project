using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour {
    private static PlayerInventory instance = new PlayerInventory();

    ArrayList inventory;

    private PlayerInventory()
    {
        inventory = new ArrayList();
    }

    public static PlayerInventory getInstance()
    {
        return instance;
    }

    public ArrayList getInventory()
    {
        return inventory;
    }
}
