using UnityEngine.UI;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class JoystickController : MonoBehaviour
{
    [Header("Button")]
    [SerializeField] private Button moveLeftButton;
    [SerializeField] private Button moveRightButton;
    [SerializeField] private Button jumpButton;
    [SerializeField] private Button shootButton;


    [Header("GameObj")]
    [SerializeField] private PlayerController player;
    [SerializeField] private Image ui_joystick;
    [SerializeField] private Image ui_shootBT;
    [SerializeField] private Image ui_jumpBT;

    [Header("Asset")]
    [SerializeField] private List<ControllerSprite> controllerSprites ;

    // Update is called once per frame
    void Update()
    {
        
    }
  

    public void Left()
    {
        player.SetMove(PlayerController.direction.MoveLeft);
        foreach (ControllerSprite i in controllerSprites)
            if (i.name == "Left") ui_joystick.sprite = i.sprite;

    }

    public void Right()
    {
        player.SetMove(PlayerController.direction.MoveRight);
        foreach (ControllerSprite i in controllerSprites)
            if (i.name == "Right") ui_joystick.sprite = i.sprite;
    }

    public void DirectUp()
    {
        player.SetMove(PlayerController.direction.Idle);
        foreach (ControllerSprite i in controllerSprites)
            if (i.name == "Normal_Joy") ui_joystick.sprite = i.sprite;
    }

    public void JumpDown()
    {
        player.Jump();
        foreach (ControllerSprite i in controllerSprites)
            if (i.name == "Jump_Down") ui_jumpBT.sprite = i.sprite;
    }
    public void JumpUp()
    {
        foreach (ControllerSprite i in controllerSprites)
            if (i.name == "Jump_Up") ui_jumpBT.sprite = i.sprite;
    }

    public void ShootDown()
    {
        foreach (ControllerSprite i in controllerSprites)
            if (i.name == "Shoot_Down") ui_shootBT.sprite = i.sprite;
    }
    public void ShootUp()
    {
        foreach (ControllerSprite i in controllerSprites)
            if (i.name == "Shoot_Up") ui_shootBT.sprite = i.sprite;
    }


}

[System.Serializable]
public class ControllerSprite
{
    public Sprite sprite;
    public string name;
}
