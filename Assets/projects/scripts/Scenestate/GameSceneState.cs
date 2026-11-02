using UnityEngine;
using UnityEngine.InputSystem;

public class GameSceneState : BaseSceneState
{
    public override string HudAddress { get; protected set;} = "Assets/projects/Prefab/GameHUDCanvas_FullHD";

    

    public void Enter()
    {
        Debug.Log($"{GetType().Name} が始まります");

        // SceneManager を取得する
        _sceneManager = GameObject.FindAnyObjectByType<SceneManager>();

        //_gameCube = GameObject.CreatePrimitive(PrimitiveType.Cube);
    }

    public void Execute()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            _sceneManager.ChangeScene( new ResultSceneState() );
        }
    }

    public void Exit()
    {
        Debug.Log($"{GetType().Name} が終わります");

        //GameObject.Destroy(_gameCube);
    }
}
