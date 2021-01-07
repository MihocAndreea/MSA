using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToysPanel : MonoBehaviour
{
    public GameObject TPanel;

    public void Toys()
    {
        if (TPanel != null)
        {
            bool isActive = TPanel.activeSelf;
            TPanel.SetActive(!isActive);
        }
    }
}
