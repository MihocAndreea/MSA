using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodPanel : MonoBehaviour
{
    public GameObject FPanel;

    public void Food()
    {
        if (FPanel != null)
        {
            bool isActive = FPanel.activeSelf;
            FPanel.SetActive(!isActive);
        }
    }
}
