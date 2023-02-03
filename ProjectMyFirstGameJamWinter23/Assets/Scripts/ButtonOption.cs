using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonOption : MonoBehaviour
{
    [SerializeField] private int option = 1;
    public int Option
    {
        get { return option; }
    }
    [SerializeField] private Texture texture;
    [SerializeField] private RawImage image;
    [SerializeField] private Color selectedColor;
    [SerializeField] private Color initColor;


    private bool isSelected = false;

    private void Start()
    {
        image.texture = texture;

        GetComponent<Button>().onClick.AddListener(SelectedOption);
    }


    private void SelectedOption()
    {
        if (!isSelected)
        {
            isSelected = true;
            GetComponent<Button>().image.color = selectedColor;
            GameObject gameController = GameObject.FindGameObjectWithTag("GameController");
            GameControler controller = gameController.GetComponent<GameControler>();
            if(controller != null)
            {
                gameController.GetComponent<GameControler>().GetOptionSelected(gameObject);
            }
            
        }
        else
        {
            isSelected = false;
            GetComponent<Button>().image.color = initColor;
        }
    }

    public void Wrong()
    {
        isSelected = false;
        GetComponent<Button>().image.color = initColor;
    }

    public void Right()
    {
        Destroy(gameObject);
    }

}
