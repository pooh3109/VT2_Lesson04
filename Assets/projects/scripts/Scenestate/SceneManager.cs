using UnityEngine;

public class SceneManager : MonoBehaviour
{
    //====メンバー変数====
    private IState _currentSceneState;  //現在実行中の画面


    void Start()
    {
        DontDestroyOnLoad(gameObject);

        _currentSceneState = new TitleSceneState(); // タイトル画面の状態を作成
        _currentSceneState.Enter();                 // タイトル画面を開始する
    }

    void Update()
    {
        _currentSceneState.Execute();               // 現在の画面を実行している
    }

    // 画面の状態を切り替える
    public void ChangeScene(IState nextScene)
    {
        // 現在の画面を終了する
        _currentSceneState.Exit();

        // 現在の画面を次の画面へ上書き
        _currentSceneState = nextScene;

        // 新しい画面を開始させる
        _currentSceneState.Enter();
    }
}
