# UniAutoAssetImporterOnPlayModeStateChanged

Unity でゲームを再生する時に指定したアセットを AssetDatabase.ImportAsset するエディタ拡張

## 使用例

```cs
using Kogane;
using UnityEditor;

[InitializeOnLoad]
public static class Example
{
    static Example()
    {
        AutoAssetImporterOnPlayModeStateChanged.PathList = new[]
        {
            "Assets/New Material.mat",
        };
    }
}
```

## 補足

- Unity でゲームを再生する時に ScriptableObject  を AssetDatabase.FindAssets しようとしたところ、  
ScriptableObject を取得できない現象に遭遇したため作成したパッケージ  
- ScriptableObject が AssetDatabase.FindAssets で見つからない現象は  
一度 Project ビューで Reimport すれば解決するため、  
Unity でゲームを再生する時に特定のアセットを Reimport するようにしたくて作成  
