using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleanPanel : MonoBehaviour
{
    public GameObject CPanel;

    public void Clean()
    {
        if (CPanel != null)
        {
            bool isActive = CPanel.activeSelf;
            CPanel.SetActive(!isActive);
        }
    }
}
