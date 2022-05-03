using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopUI : MonoBehaviour
{
    int currentIndex = 0;
    [SerializeField] Sprite[] characters;
    [SerializeField] RuntimeAnimatorController[] controllers;
    [SerializeField] Image preview;
    int currentEquipIndex = 0;
    [SerializeField] SpriteRenderer playerRenderer;
    [SerializeField] Animator playAnimator;
    public void NextCharacter()
    {
        if (currentIndex < characters.Length - 1)
        {
            currentIndex++;
            preview.sprite = characters[currentIndex];
        }
    }
    public void PreviousCharacter()
    {
        if (currentIndex > 0)
        {
            currentIndex--;
            preview.sprite = characters[currentIndex];
        }
    }
    public void Equip()
    {
        if (currentEquipIndex != currentIndex)
        {
            playerRenderer.sprite = characters[currentIndex];
            playAnimator.runtimeAnimatorController = controllers[currentIndex];
            currentEquipIndex = currentIndex;
        }
    }
}
