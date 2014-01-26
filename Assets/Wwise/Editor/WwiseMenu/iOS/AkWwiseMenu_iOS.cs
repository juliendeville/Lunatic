#if UNITY_EDITOR

using UnityEngine;
using UnityEditor;
using System.Diagnostics;
using System.IO;
using System.Collections.Generic;
using System;


public class AkWwiseMenu_iOS : MonoBehaviour {

	private static AkUnityPluginInstaller_iOS m_installer = new AkUnityPluginInstaller_iOS();

	private static AkUnityIntegrationBuilder_iOS m_builder = new AkUnityIntegrationBuilder_iOS();

	[MenuItem("Wwise/Install Plugins/iOS/Debug")]
	public static void InstallPlugin_Debug () {
		m_installer.InstallPluginByConfig("Debug");
	}

	[MenuItem("Wwise/Install Plugins/iOS/Profile")]
	public static void InstallPlugin_Profile () {
		m_installer.InstallPluginByConfig("Profile");
	}

	[MenuItem("Wwise/Install Plugins/iOS/Release")]
	public static void InstallPlugin_Release () {
		m_installer.InstallPluginByConfig("Release");
	}

	[MenuItem("Wwise/Rebuild Integration/iOS/Debug")]
	public static void RebuildIntegration_Debug () {
		m_builder.BuildByConfig("Debug", null);
	}

	[MenuItem("Wwise/Rebuild Integration/iOS/Profile")]
	public static void RebuildIntegration_Profile () {
		m_builder.BuildByConfig("Profile", null);
	}

	[MenuItem("Wwise/Rebuild Integration/iOS/Release")]
	public static void RebuildIntegration_Release () {
		m_builder.BuildByConfig("Release", null);
	}

	[MenuItem("Wwise/Help")]
	public static void OpenDoc () {
		string docPath = string.Format("{0}/Wwise/Documentation/WwiseUnityIntegration_Standard.html", Application.dataPath);
		FileInfo fi = new FileInfo(docPath);
		if ( ! fi.Exists )
		{
			UnityEngine.Debug.LogError(string.Format("Wwise: Failed to find documentation: {0}. Aborted.", docPath));
			return;
		}

		string docUrl = string.Format("file:///{0}", docPath);
		
		Application.OpenURL(docUrl);
	}
}


public class AkUnityPluginInstaller_iOS : AkUnityPluginInstallerBase
{
	public AkUnityPluginInstaller_iOS()
	{
		m_platform = "iOS";
	}

	protected override string GetPluginDestPath()
	{
		return Path.Combine(m_pluginDir, m_platform);
	}	
}


public class AkUnityIntegrationBuilder_iOS : AkUnityIntegrationBuilderBase
{
	public AkUnityIntegrationBuilder_iOS()
	{
		m_platform = "iOS";
	}
}
#endif // #if UNITY_EDITOR