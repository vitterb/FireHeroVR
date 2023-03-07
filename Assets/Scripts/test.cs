using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class test : MonoBehaviour
{
    public TMP_Text infoText;
    public TMP_Text StageText;

    string infoAcrofobie = "fear of heigths, you'll go to a balcony and will have to go to the edge.";
    string infoArachnafobie = "fear of spiders, you'll have to be in the same room as a spider, it will grow and start to move";

    string AcrofogieStages = "1. 8m\n2. 12m\n3. 20m ";
    string ArachnafobieStages = "1. small spider\n2. small moving spider\n3. big spider\n big moving spider";
    public void pressedbuttonAcrofobie()
    {
        infoText.text = infoAcrofobie;
        StageText.text = AcrofogieStages;
    }
    public void pressedbuttonArachnafobie()
    {
        infoText.text = infoArachnafobie;
        StageText.text = ArachnafobieStages;
    }
}
