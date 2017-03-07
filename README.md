# Unity3DCameraTest
Unity上であっち向いてそのまま進むについて
左右矢印キーでカメラが左右に首を振り。ｚとｘキーで上下に首を振る。
その状態で、上キーを進むとカメラの方向に進む。

camera.transform.forwardでカメラの方向を取得して、AcosとAtan2を使って進む方向を取得。

[参考サイト]
Wikipedia 球面座標系
https://ja.wikipedia.org/wiki/%E7%90%83%E9%9D%A2%E5%BA%A7%E6%A8%99%E7%B3%BB
