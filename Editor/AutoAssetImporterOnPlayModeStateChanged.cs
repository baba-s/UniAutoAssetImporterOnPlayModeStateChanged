using UnityEditor;

namespace Kogane
{
	[InitializeOnLoad]
	public static class AutoAssetImporterOnPlayModeStateChanged
	{
		public static string[] PathList { get; set; } = new string[0];

		static AutoAssetImporterOnPlayModeStateChanged()
		{
			void OnChanged( PlayModeStateChange change )
			{
				if ( PathList == null ) return;
				if ( change != PlayModeStateChange.ExitingEditMode ) return;

				foreach ( var path in PathList )
				{
					AssetDatabase.ImportAsset( path, ImportAssetOptions.ForceUpdate );
				}
			}

			EditorApplication.playModeStateChanged += OnChanged;
		}
	}
}