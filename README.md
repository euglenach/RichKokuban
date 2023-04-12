# RichKokuban
TextMeshPro向けのリッチテキスト生成ライブラリ

例
```csharp
var result = Align.Center + 
             Chalk.Yellow + "Hello" + Chalk.Grey["," + Chalk.Red["World!\n"]] +
             Chalk.Color(Color.blue, "This is ") + Chalk.Color(Color.green, "RichKokuban.\n") +
             " Thanks for " +  Chalk.Magenta["installing "] + "it!";
```

![](doc/img/sample2.jpg)