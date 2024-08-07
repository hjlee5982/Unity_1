using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static Define;

public class GameScene : BaseScene
{
    public override bool Init()
    {
        if (base.Init() == false)
        {
            return false;
        }

        SceneType = Define.EScene.GameScene;

        GameObject map = Managers.Resource.Instantiate("BaseMap");
        map.transform.position = Vector3.zero;
        map.name = "@BaseMap";

        Hero hero = Managers.Object.Spawn<Hero>(Vector3.zero);
        hero.CreatureState = Define.ECreatureState.Move;

        Managers.UI.ShowBaseUI<UI_Joystick>();

        CameraController camera = Camera.main.GetOrAddComponent<CameraController>();
        camera.Target = hero;

        {
            Monster monster = Managers.Object.Spawn<Monster>(new Vector3Int(0, 1, 0));
            monster.CreatureState = ECreatureState.Idle;
        }
        // TODO

        return true;
    }

    public override void Clear()
    {

    }
}
