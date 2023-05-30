using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonClickScript : MonoBehaviour
{
    public Text outputText; // Ссылка на текстовый компонент, где будет выводиться текст

    private void Start()
    {
        // Получаем ссылку на компонент кнопки и добавляем обработчик события клика
        Button button = GetComponent<Button>();
        button.onClick.AddListener(OnClick);
    }

    private void OnClick()
    {
        // Здесь можно задать любой текст, который будет выводиться при клике на кнопку
        outputText.text = "Я пошутил, так игру ты не закроешь, воспользуйся alt + f4";
    }
}

