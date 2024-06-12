using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject chat;
    public GameObject profile;
    public Image BG;
    public Sprite[] sprites;
    public void ShowChatBox()
    {
        // show the chat box!!
        Debug.Log("chatbox I need you");
    }
    public void GoToChat()
    {
        chat.SetActive(true);

        profile.SetActive(false);
        BG.sprite = sprites[0];
    }
    public void GoToProfile()
    {
        chat.SetActive(false);

        profile.SetActive(true);
        BG.sprite = sprites[1];
    }
}
