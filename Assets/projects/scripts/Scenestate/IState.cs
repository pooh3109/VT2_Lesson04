using UnityEngine;

// このインターフェイスを継承するクラスは,
// 記述されているメソッドやプロパティを全て実装しなければならない

public interface IState
{
    void Enter();   // 状態の初期化

    void Execute(); // 状態の繰り返し処理

    void Exit();    // 状態の終了処理
}
