using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.SceneManagement;
using System.Threading;

public class GameManager : MonoBehaviour
{
    //all states off languages
    public TextMeshProUGUI LanguageTitle;
    public TextMeshProUGUI LanguageText;
    public string ChosenLanguage = "ENG";


    public TextMeshProUGUI Infotext;

    public TextMeshProUGUI MoveTitle;
    public TextMeshProUGUI Movetext; 

    public TextMeshProUGUI BuddyTitle;
    public TextMeshProUGUI BuddyInfo;
    public TextMeshProUGUI Yourbuddy;
    public string chosenbuddy;



    public TextMeshProUGUI ChoosefearTitle;
    public TextMeshProUGUI Choosefear;
    public TextMeshProUGUI yourfear;
    public string ChosenFear;


    public TextMeshProUGUI FearTitle;
    public TextMeshProUGUI FearInfo;

    public TextMeshProUGUI LevelTitle;
    public TextMeshProUGUI LevelInfo;

    public TextMeshProUGUI BeginFearTitle;
    public TextMeshProUGUI BeginFearInfo;

    public TextMeshPro BookLeft;
    public TextMeshPro BookRight;
    public void chooseEnglish()
    {
        ChosenLanguage = "ENG";
    }
    public void ChooseNL()
    {
        ChosenLanguage = "NL";
    }
    public void chooseTeddy()
    {
        chosenbuddy = "Teddy";
    }
    public void chooseVoice()
    {
        chosenbuddy = "Voice";
    }

    public void ChooseHeigths()
    {
        ChosenFear = "Heigths";
    }
    public void ChooseSpiders()
    {
        ChosenFear = "Spiders";
    }

public void BookInformation()
    {
                BookLeft.text = FearInfo.text;
                BookRight.text = LevelInfo.text;
    }
public void SelectLanguage()
    {
        switch (ChosenLanguage) 
        {
            case "ENG":
                LanguageTitle.text = "Choose your language";
                LanguageText.text = "Choose the language to use in these menu's";
                break;
            case "NL":
                LanguageTitle.text = "Kies de taal";
                LanguageText.text = "kies de taal in de menu's";
                break;
            default:
                break;
        }
    }
    public void SelectInfo()
    {
        switch (ChosenLanguage)
        {
            case "ENG":
                Infotext.text = "this experience will help you conquer your fears\n follow the steps and listen to your buddy.";
                break;
            case "NL":
                Infotext.text = "deze ervaring zal u helpen met u angsten te overwinnen";
                break;
            default:
                break;
        }
    }
    public void SelectMovement()
    {
        switch (ChosenLanguage)
        {
            case "ENG":
                MoveTitle.text = "Movement";
                Movetext.text = "to turn just turn your head\n To move use the left joystick";
                break;
            case "NL":
                MoveTitle.text = "beweging";
                Movetext.text = "om te draaien gebruik je je hoofd, gewoon zoals je naar rechts of links kijkt\n om te verplaatsen gebruik de linker joystick";
                break;
            default:
                break;
        }
    }
    public void SelectBuddy()
    {
        switch (ChosenLanguage)
        {
            case "ENG":
                BuddyTitle.text = "Your best buddy!";
                BuddyInfo.text = "choose a buddy who will guide and help you conquer your fear";
                if (chosenbuddy == "Teddy")
                {
                    Yourbuddy.text = "you selected Teddy to be your buddy!";
                }
                else if (chosenbuddy == "Voice")
                {
                    Yourbuddy.text = "you selected a Voiceover to help you conquer your fear.";
                }
                else
                {
                    Yourbuddy.text = "You chose no buddy.";
                }
                break;
            case "NL":
                BuddyTitle.text = "u beste Buddy!";
                BuddyInfo.text = "kies u vriend. dat u zal helpen met u angsten te overwinnen";
                if (chosenbuddy == "Teddy")
                {
                    Yourbuddy.text = "Je hebt teddy gekozen als vriend!";
                }
                else if (chosenbuddy == "Voice")
                {
                    Yourbuddy.text = "je hebt gekozen om je te laten bijstaan door een voiceover";
                }
                else
                {
                    Yourbuddy.text = "Je hebt geen vriend gekozen";
                }
                break;
            default:
                break;
        }      
    }
    public void SelectChoosefear()
    {
        switch (ChosenLanguage)
        {
            case "ENG":
                ChoosefearTitle.text = "choose your fear";
                Choosefear.text = "Choose which fear you want to conquer! just press a poster like you did with the buttons.";
                if (ChosenFear == "Heigths")
                {
                    yourfear.text = "you want to conquer Acrofobia";
                }
                else if (ChosenFear == "Spiders")
                {
                    yourfear.text = "you want to conquer Arachnafobia";
                }
                break;
            case "NL":
                ChoosefearTitle.text = "kies u angst";
                Choosefear.text = "kies welke angst je wilt overwinnen! klick gewoon op de poster net zoals je hebt gedaan met de knop.";
                if (ChosenFear == "Heigths")
                {
                    yourfear.text = "je wil Acrofobie overwinnen!";
                }
                else if (ChosenFear == "Spiders")
                {
                    yourfear.text = "je wil Arachnafobie overwinnen!";
                }
                break;
            default:
                break;
        }
    }
    public void SelectFearinfo()
    {
        ChooseLevelInfo();
        switch (ChosenLanguage)
        {
            case "ENG":
                switch (ChosenFear)
                {
                    case "Heigths":
                        FearTitle.text = "Acrofobia";
                        FearInfo.text = "fear of heigths, you will experience diffrent heigths and types of buildings to conquer acrofobia";
                        yourfear.text = "you want to conquer Acrofobia";
                        break;
                    case "Spiders":
                        FearTitle.text = "Arachnafobia";
                        FearInfo.text = "fear of spiders, you'll have to be in the same room as a spider, it will grow and start to move";
                        yourfear.text = "you want to conquer Arachnafobia";
                        break;
                    default:
                        break;
                }
                break;
            case "NL":
                switch (ChosenFear)
                {
                    case "Heigths":
                        FearTitle.text = "Acrofobie";
                        FearInfo.text = "angst van hoogte, je zal verschillende hoogtes en types gebouwen ervaren om je angst te overwinnen";
                        yourfear.text = "je wil Acrofobie overwinnen!";
                        break;
                    case "Spiders":
                        FearTitle.text = "Arachnafobie";
                        FearInfo.text = "angst van spinnen, je word in een kamer gezet met een spin die groter word en zal bewegen";
                        yourfear.text = "je wil Arachnafobie overwinnen!";
                        break;
                    default:
                        break;
                }
                break;
            default:
                break;
        }
        BookInformation();
    }
    public void ChooseLevelInfo()
    {
        switch (ChosenLanguage)
        {
            case "ENG":
                LevelTitle.text = "Difficulty: in the elevator you can choose the difficulty. 1 is easy, 10 is hard";
                switch (ChosenFear)
                {
                    case "Heigths":
                        LevelInfo.text = "1. 8m\n2. 12m\n3. 20m\n ... ";
                        break;
                    case "Spiders":
                        LevelInfo.text = "1. small spider\n2. small moving spider\n3. big spider\n big moving spider";
                        break;
                    default:
                        break;
                }
                
                break;
            case "NL":
                LevelTitle.text = "moeilijkheid: in de lift kan je de moeilijkheid selecteeren. 1 is makelijk, 10 is moeilijk";
                switch (ChosenFear)
                {
                    case "Heigths":
                        LevelInfo.text = "1. 8m\n2. 12m\n3. 20m\n ... ";
                        break;
                    case "Spiders":
                        LevelInfo.text = "1. kleine spin\n2. klein en bewegende spin\n3. grote spin\n groote bewegende spin";
                        break;
                    default:
                        break;
                }
                
                break;
            default:
                break;
        }        
    }
    public void SelectStart()
    {
        switch (ChosenLanguage)
        {
            case "ENG":
                BeginFearTitle.text = "Begin your experience!";
                BeginFearInfo.text = "to start your experience step into the elevator and choose your difficulty";
                break;
            case "NL":
                BeginFearTitle.text = "start u belevenis!";
                BeginFearInfo.text = "om te starten stap in de lift en kies u moeilijkheid";
                break;
            default:
                break;
        }
    }




    //Scenemanager
    int levelselect;

    public void pushbutton()
    {
        Scenemanager();
    }
    public void Scenemanager()
    {
        
        if (chosenbuddy == "Teddy")
        {
                SceneManager.LoadScene("ElevatorTeddy");
        }
        else
        {
                SceneManager.LoadScene("Elevator");
        }
       
    }
}