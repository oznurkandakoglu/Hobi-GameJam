using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class UpdateHealth : MonoBehaviour
{

    public PlayerProperties playerProperties;
    
    public TMP_Text healthText;
    public TMP_Text keyText;

    //public MoveGround mg;
    //public TMP_Text speedText;

    // Update is called once per frame
    void Update()
    {
        healthText.text = playerProperties.health.ToString();
        keyText.text = playerProperties.goldKey.ToString();
        //speedText.text ="Speed" + mg.moveSpeed.ToString();
    }
}
