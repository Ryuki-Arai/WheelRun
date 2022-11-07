# WheelRun
ハイパーカジュアルゲームにおけるランゲームの開発  
**[NOKIAのCM](https://www.youtube.com/watch?v=Ir5fZZOkmRs)に出てくるみたいなタイヤが走る新タイプのゲーム**

## 開発環境
* Unity
* Visual Sutdio 2022

## ゲームの内容
* 3レーンをフリックで移動し走る
* **時折レーン移動時にふらつく**
* 障害物にあたるとHPが減る
* 敵に体当たりで敵を倒せる
  * 車輪の種類によって自身のHPを消費する

## 実装
* フィールド
  * レーンを3つ用意する
* ギミック・アイテム
  * コイン：取得でスコア加算
  * 障害物：接触でHP減少
  * 敵：倒すとスコアアップ/場合によりHP減少
* 車輪
  * 左右操作でレーンを移動
  * ふらつき
    * バランス値の内部パラメータを用意、0で転倒(ゲームオーバー)
    * 見た目は後回し
  * ダメージ
    * 敵や障害物との接触でHP減少、0でゲームオーバー
* ステージクリア型のゲームプレイ
  * だいたい500mのステージを用意して、1~2m/sくらいのスピードをイメージ
  * それぞれのレーンにコインを1mおきに並べつつ、適当(完全ランダムでもいい)なコインを障害物や敵に挿げ替える

## サクッと作ってみた
<img height="600" alt="GameScreenMovie1" src="https://github.com/Ryuki-Arai/WheelRun/blob/main/README_Picture/Screen_Recording_20221107_114253_Unity-Remote-5.gif"> 
