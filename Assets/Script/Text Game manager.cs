using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using JetBrains.Annotations;

public class TextGamemanager : MonoBehaviour
{
    public TextMeshProUGUI storyTextMeshPro, hpTextMeshPro, staminaTextMeshPro;
    public string storyText;
    public int hpValue, staminaValue;
    public GameObject level_1_Choices, levelchoice, Accept_lvl_1, level2;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        storyTextMeshPro.text = storyText;
        hpTextMeshPro.text = hpValue.ToString();
        staminaTextMeshPro.text = staminaValue.ToString();
    }

    public void tryToRecall()
    {
        storyText = "\"I'm very short tempered right now so recall very quickly.\"\r\nThere was no time to recall slowly but you try to think how you got here. You never encountered any red ball on the way.\r\n\"Thank you for being honest with me. here's a gift.\"";
        level_1_Choices.SetActive(false);
        Accept_lvl_1.SetActive(true);
    }

    public void Taunt()
    {
        storyText = "You taunted the witch, trying to display unessecary bravery.\r\n\"have it your way.\" The witch froze you out of annoyance.";
        level_1_Choices.SetActive(false);
    }

    public void runAway()
    {
        storyText = "Fearing that the witch will do you harm, you try to run as fast as a bunny, hopping down a sloping mountain.\r\nonly boundless darkness was left.";
        hpValue -=10;
        level_1_Choices.SetActive(false);
    }

    public void witchPotion()
    {
        Accept_lvl_1.SetActive(false);
        hpValue += 10;
        storyText = "Although the witch was short-tempered, she was good of heart";
        level2.SetActive(true);
    }

    public void Continue()
    {
        storyText = "You continue on your way, deciding not to drink, and returned home safely.";
        level2.SetActive(false);
    }

    public void Retry()
    {
        storyText = "maybe there could be something more";
        level2.SetActive(false);
        level_1_Choices.SetActive(true);
        levelchoice.SetActive(false);
    }

    public void DrinkPotion()
    {
        storyText = "Drinking the potion made you feel stronger and more able, you felt as though you live a long life";
        hpValue += 1000;
        staminaValue += 500;
    }
}
