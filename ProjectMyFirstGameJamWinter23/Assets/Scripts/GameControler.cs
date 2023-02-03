using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControler : MonoBehaviour
{

    private List<ButtonOption> buttonOptions;

    private void Start()
    {
        buttonOptions = new List<ButtonOption>();
    }

    public void GetOptionSelected(GameObject option)
    {
        ButtonOption buttonOption = option.GetComponent<ButtonOption>();
        if (buttonOption != null)
        {
            buttonOptions.Add(buttonOption);
        }

        if(buttonOptions.Count == 3)
        {
            Debug.Log("3 buttons selected");
            if (buttonOptions[0].Option == buttonOptions[1].Option &&
                buttonOptions[0].Option == buttonOptions[2].Option)
            {
                Debug.Log("Match");
                buttonOptions[0].Right();
                buttonOptions[1].Right();
                buttonOptions[2].Right();
            }
            else
            {
                Debug.Log("Not a match");
                buttonOptions[0].Wrong();
                buttonOptions[1].Wrong();
                buttonOptions[2].Wrong();
            }
            buttonOptions.Clear();
            Debug.Log("After clear: " + buttonOptions.Count.ToString()) ;
        }
    }

}
