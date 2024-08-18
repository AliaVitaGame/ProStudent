using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelActivation : MonoBehaviour
{
    [SerializeField] private GameObject[] allPanel;

    public void DeactiveAllPanel()
    {
        for (int i = 0; i < allPanel.Length; i++)
        {
            if (allPanel[i])
                allPanel[i].SetActive(false);
        }
    }
}
