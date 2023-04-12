# RichKokuban
TextMeshPro向けのリッチテキスト生成ライブラリ

例
```csharp
var result = Align.Center + 
             Chalk.Yellow + "Hello" + Chalk.Grey["," + Chalk.Red["World!\n"]] +
             Chalk.Color(Color.blue, "This is ") + Chalk.Color(Color.green, "RichKokuban.\n") +
             " Thanks for " +  Chalk.Magenta["installing "] + "it!";
```

![sample](https://user-images.githubusercontent.com/28961922/231379960-db89f9fb-992a-4848-a376-577e98024335.jpg)
