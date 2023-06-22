using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameBehaviour : MonoBehaviour
{

    private int _itemsCollected = 0;
    private int _playerHP = 10;
    public int MaxItems = 4;
    public TMP_Text HealthText;
    public TMP_Text ItemText;
    public TMP_Text ProgressText;
    public Button WinButton;
    public int Items
    {
        get
        {
            return _itemsCollected;
        }
        set{
            _itemsCollected = value;
            ItemText.text = "Items Collected: " + Items;
            if(_itemsCollected >= MaxItems)
            {
                ProgressText.text = "You've found all the items!";
                WinButton.gameObject.SetActive(true);
                Time.timeScale = 0f;
            }
            else{
                ProgressText.text = "Item found, only " + (MaxItems - _itemsCollected) + " more!";
            }
        }
    }
    public int HP   
    {
        get{
            return _playerHP;
        }
        set{
            _playerHP= value;
            HealthText.text = "Player Health: " + HP;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        ItemText.text += _itemsCollected;
        HealthText.text += _playerHP;                
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RestartScene()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }
}
