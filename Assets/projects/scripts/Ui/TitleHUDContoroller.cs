using UnityEngine;

public class TitleHUDContoroller
{
    //メンバー変数
    private TitleHUDView _view;             //HUDのビュー
    private TitleSceneState _sceneState;    //シーンの状態

    
   // コンストラクタ
   public TitleHUDContoroller(TitleHUDView view, TitleSceneState sceneState)
   {
        _view = view;
        _sceneState = sceneState;

        // ボタン押下時のイベントを登録
        _view.onClickButtonAction += onClickButtonRequest;
   }

   private void onClickButtonRequest()
   {
        _sceneState.AddScore();
   }
}
