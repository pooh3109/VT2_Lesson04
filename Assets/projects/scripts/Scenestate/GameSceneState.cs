using UnityEngine;
using UnityEngine.InputSystem;

public class GameSceneState : IState
{
    private SceneManager _sceneManager;

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
