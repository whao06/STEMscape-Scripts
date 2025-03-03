// Handle gravity panel display

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChangeGravityPanel : MonoBehaviour
{
    private Image panelImage;

    public GameObject panelObject;
    public TextMeshProUGUI statusText;
    // public Color gravityEnabledColor;
    // public Color gravityDisabledColor;
    

    // Start is called before the first frame update
    void Start()
    {
        panelImage = panelObject.GetComponent<Image>();
        statusText = panelObject.GetComponentInChildren<TextMeshProUGUI>();
    }

    public void OnLeverDeactivated()
    {
        panelImage.color = Color.red;
        statusText.text = "Gravity Disabled";
    }

    public void OnLeverActivated()
    {
        panelImage.color = Color.green;
        statusText.text = "Gravity Enabled";
    }
}
