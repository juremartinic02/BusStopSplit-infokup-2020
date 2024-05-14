using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SendingTextLabelUpdater : MonoBehaviour
{
    public MainController mainController;

    private bool shouldSend = false;

    private Text text;
    // Start is called before the first frame update
    void Start()
    {
        this.text = this.GetComponent<Text>();
        UpdateText();
    }

    // Update is called once per frame
    void Update()
    {
        if (shouldSend != mainController.ShouldSend)
        {
            shouldSend = mainController.ShouldSend;

            UpdateText();
        }
    }

    private void UpdateText()
    {
        if (shouldSend)
        {
            text.text = "Sending...";
        }
        else
        {
            text.text = "Not sending!";
        }
    }
}
