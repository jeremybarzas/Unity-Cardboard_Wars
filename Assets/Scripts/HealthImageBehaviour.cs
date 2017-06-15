using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using System.Linq;

public class HealthImageBehaviour : MonoBehaviour
{
    public TankBehaviour player;
    public Image image;
    public string startstring = "healthbar_";
    public string endstring = "%";
    void Awake()
    {
       TankBehaviour.onHealthChanged.AddListener(SetImage);
    }

    void Start()
    {
        image = GetComponent<Image>();
    }

    public void SetImage(string value)
    {
        //i'm expecting a string that looks like "Player1,<hpnumber>"
        var splitstring = value.Split(',');

        var playerId = splitstring[0];

        if (name != playerId)
            return;
        var playerHp = splitstring[1];
        
        var spriteToLoadName = startstring + playerHp + endstring;
        var spritesheet = Resources.LoadAll<Sprite>("healthbar");
        var sprite = spritesheet.FirstOrDefault(x => x.name == spriteToLoadName);
        if (sprite == null)
        {
            Debug.LogWarning(":(");
            return;
        }

        image.overrideSprite = sprite;
    }

}
