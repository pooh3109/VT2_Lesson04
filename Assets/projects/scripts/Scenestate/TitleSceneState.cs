using UnityEngine;
using UnityEngine.InputSystem;

public class TitleSceneState : IState
{
    private SceneManager _sceneManager;

    public void Enter()
    {
        Debug.Log($"{GetType().Name} が始まります");

        // SceneManager を取得する
        _sceneManager = GameObject.FindAnyObjectByType<SceneManager>();
    }

    public void Execute()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            _sceneManager.ChangeScene( new GameSceneState() );
        }
    }

    public void Exit()
    {
        Debug.Log($"{GetType().Name} が終わります");
    }
}
