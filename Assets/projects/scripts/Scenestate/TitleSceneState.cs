using UnityEngine;
using UnityEngine.InputSystem;

public class TitleSceneState : BaseSceneState
{
    public override string HudAddress { get; protected set;} = "Assets/projects/Prefab/TitleHUDCanvas_FullHD";

    private TitleHUDContoroller _hudContoroller;
    private int _score;

    public void Enter()
    {
        base.Enter();

        var hudView = new TitleHUDView();
        hudView.Initialize(_hudCanvas.GetComponent<Canvas>());

        // HUDのコントローラーを初期化
        _hudContoroller = new TitleHUDContoroller(hudView, this);
    }

    public void Execute()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            _sceneManager.ChangeScene(new GameSceneState());
        }

        base.Execute();
    }

    public void Exit()
    {
        base.Exit();
    }

    public void AddScore()
    {
        _score++;
    }
}
