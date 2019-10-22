using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    [SerializeField]
    Sprite redReticle;
    [SerializeField]
    Sprite yellowReticle;
    [SerializeField]
    Sprite blueReticle;
    [SerializeField]
    Image reticle;

    [SerializeField]
    private Text ammoText;
    [SerializeField]
    private Text healthText;
    [SerializeField]
    private Text armourText;
    [SerializeField]
    private Text scoreText;
    [SerializeField]
    private Text pickupText;
    [SerializeField]
    private Text waveText;
    [SerializeField]
    private Text waveClearText;
    [SerializeField]
    private Text newWaveText;
    [SerializeField]
    Player player;

    public void UpdateReticle()
    {
        switch (GunEquipper.activeWeaponType)
        {
            case Constants.Pistol:
                reticle.sprite = redReticle;
                break;
            case Constants.Shotgun:
                reticle.sprite = yellowReticle;
                break;
            case Constants.AssaultRifle:
                reticle.sprite = blueReticle;
                break;
            default:
                return;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        SetArmourText(playuer.armour);
        SetHealthText(player.health);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetArmourText(int armor)
    {
        armourText.text = "Armour: " + armourText;
    }
    public void SetHealthText(int health)
    {
        healthText.text = "Health: " + health;
    }
    public void SetAmmoText(int ammo)
    {
        ammoText.text = "Ammo " + ammo;
    }
    public void SetScoreText(int score)
    {
        scoreTexst.text = "" + score;
    }
    public void SetWaveText (int time)
    {
        waveText.text = "Next Wave: " + time;
    }
    public void SetEnemyText(int enemies)
    {
        SetEnemyText.text = "Enemies: " + enemies;
    }

    public void ShowWaveClearBonus()
    {
        waveClearText.GetComponent<waveClearText>().enabled = true;
        StartCoroutine("hideWaveClearBonus");        
    }
    IEnumerator hideWaveClearBonus()
    {
        yield return new WaitForSeconds(4);
        waveClearText.GetComponent<waveClearText>().enabled = false;
    }
    public void SetPickUpText(string text)
    {
        pickupText.GetComponent<text>().enabled = true;
        pickupText.text = text;
        StopCoroutine("hidePickupText");
        StartCoroutine("hidePickupText");
    }IEnumerator hidPickUpText()
    {
        yield return new WaitForSeconds(4);
        pickupText.GetComponent<pickupText>().enabled = false;
    }
    public void ShowNewWaveText()
    {
        StartCoroutine("hideNewWaveText");
        newWaveText. GetComponent<Text>().enabled = true;
    }
    IEnumerator hideNewWaveText()
    {
        yield return new WaitForSeconds(4);
        newWaveText.GetComponent<newWaveText>().enabled = false;
    }
}
