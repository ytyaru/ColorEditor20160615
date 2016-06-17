# このソフトウェアについて #

ColorEditor20160615は私個人が学習目的で作成したソフトウェアです。

[色編集アプリ](https://github.com/ytyaru/ColorEditor20160614)を改修しました。
ウインドウサイズ変更に伴う適切なUI配置がされるよう対処しました。

# 開発環境 #

* Windows XP SP3
* .NET Framework 4.0
* Windows Form Application
* C#
* Visual C# 2010 Express

# イメージ #

![小さい](http://cdn-ak.f.st-hatena.com/images/fotolife/y/ytyaru/20160617/20160617182336.png)
![大きい](http://cdn-ak.f.st-hatena.com/images/fotolife/y/ytyaru/20160617/20160617182345.png)

# 改修内容 #

* ウインドウサイズを大きくすると隙間が開いてしまう
    * Anchorプロパティで自動調整するようにした
* ウインドウサイズを小さくしすぎるとUI操作ができなくなってしまう
    * ウインドウの高さの最小値を128にした

ついでに以下も行った。

* TrackBar
    * 目盛り非表示にした（TickStyle=None）
* NumericUpDown
    * Fontを変更した（Size=12, Style=Bold）
    * 枠を外した（BorderStyle=None）
* Panel
    * 座標を微調整した

# ライセンス #

このソフトウェアはCC0ライセンスです。

[![CC0](http://i.creativecommons.org/p/zero/1.0/88x31.png "CC0")](http://creativecommons.org/publicdomain/zero/1.0/deed.ja)
