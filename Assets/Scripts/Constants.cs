using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Constants
{
    //scenes
    public const string SceneBattle = "Battle";
    public const string SceneMenu = "MainMenu";

    //gun Types
    public const string Pistol = "Pistol";
    public const string Shotgun = "Shotgun";
    public const string AssaultRifle = "AssaultRifle";

    // Robot Types
    public const string RedRobot = "RedRobot";
    public const string BlueRobot = "BlueRobot";
    public const string YellowRobot = "YellowRobot";

    //pickup types
    public const int PickUpPistolAmmo = 1;
    public const int PickUpAssaultRifleAmmo = 2;
    public const int PickUpShotgunAmmo = 3;
    public const int PickUpHealth = 4;
    public const int PickUpArmor = 5;

    //Misc
    public const string Game = "Game";
    public const float CameraDefaultZoom = 60f;

    public const float MaxAreanaX = 29.0f;
    public const float MinAreanaX = -29.0f;
    public const float MaxAreanaZ = 29.0f;
    public const float MinAreanaZ = -29.0f;

    public static readonly int[] AllPickupTypes = new int[5]
    {
        PickUpPistolAmmo,
        PickUpAssaultRifleAmmo,
        PickUpShotgunAmmo,
        PickUpHealth,
        PickUpHealth
    };
}
