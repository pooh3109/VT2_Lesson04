using UnityEngine;

/// <summary>
/// キャンバス(またはUIドキュメント)を取り扱うクラス
/// <summary>
public class TitleHUDView
{
    public Action onClickButtonAction;  // ボタン押下時のイベント

    private Button _clickButton;

    //初期化メソッド
   public void Initialize(Canvas uiCanvas)
   {
        // キャンバス内の要素を取得する
        _clickButton = uiCanvas.GetComponentInChildren<Button>();

        // イベントの割り当て
        if(_clickButton != null)
            _clickButton.onClick.AddLisener(onClickButton);
   }

   private void onClickButton()
   {
        Debug.Log("ボタンが押されました");

        // イベントを発火する
        onClickButtonAction?.Invoke; 
   }
}
