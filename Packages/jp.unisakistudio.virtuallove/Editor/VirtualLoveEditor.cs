using UnityEngine;
using UnityEditor;
using Microsoft.Win32;
using jp.unisakistudio.virtuallove;
using System.Collections.Generic;

namespace jp.unisakistudio.virtualloveeditor
{

    [CustomEditor(typeof(VirtualLove))]
    public class VirtualLoveEditor : posingsystemeditor.PosingSystemEditor
    {
        internal const string REGKEY = @"SOFTWARE\UnisakiStudio";
        internal const string APPKEY_BOY = "virtuallove_boy";
        internal const string APPKEY_GIRL = "virtuallove_girl";
        private bool isVirtualLoveBoyLicensed = false;
        private bool isVirtualLoveGirlLicensed = false;

        static VirtualLoveEditor()
        {
            checkFunctions.Add(CheckExistFolderVirtualLove);
        }
    
        public override void OnInspectorGUI()
        {
            VirtualLove virtualLove = target as VirtualLove;

            /*
             * このコメント分を含むここから先の処理は三点だいしゅきツールをゆにさきスタジオから購入した場合に変更することを許可します。
             * つまり購入者はライセンスにまつわるこの先のソースコードを削除して再配布を行うことができます。
             * 逆に、購入をせずにGithubなどからソースコードを取得しただけの場合、このライセンスに関するソースコードに手を加えることは許可しません。
             */
            if (virtualLove.isBoy && isVirtualLoveBoyLicensed)
            {
                base.OnInspectorGUI();
                return;
            }
            if (!virtualLove.isBoy && isVirtualLoveGirlLicensed)
            {
                base.OnInspectorGUI();
                return;
            }

            bool hasLicense = false;

            // Windows: レジストリをチェック
#if UNITY_EDITOR_WIN
            try
            {
                var regKey = Registry.CurrentUser.CreateSubKey(REGKEY);

                if (virtualLove.isBoy)
                {
                    var regValueBoy = (string)regKey.GetValue(APPKEY_BOY);
                    if (regValueBoy == "licensed")
                    {
                        hasLicense = true;
                    }
                }
                else
                {
                    var regValueGirl = (string)regKey.GetValue(APPKEY_GIRL);
                    if (regValueGirl == "licensed")
                    {
                        hasLicense = true;
                    }
                }
            }
            catch (System.Exception)
            {
                // レジストリアクセスに失敗した場合は次のチェックへ
            }
#endif

            // Mac/Linux: 設定ファイルをチェック
#if UNITY_EDITOR_OSX || UNITY_EDITOR_LINUX
            if (!hasLicense)
            {
                try
                {
                    string appKey = virtualLove.isBoy ? APPKEY_BOY : APPKEY_GIRL;
                    string licenseFilePath = GetLicenseFilePath(appKey);
                    if (System.IO.File.Exists(licenseFilePath))
                    {
                        string fileContent = System.IO.File.ReadAllText(licenseFilePath);
                        if (fileContent == "licensed")
                        {
                            hasLicense = true;
                        }
                    }
                }
                catch (System.Exception)
                {
                    // ファイルアクセスに失敗
                }
            }
#endif

            if (hasLicense)
            {
                if (virtualLove.isBoy)
                {
                    isVirtualLoveBoyLicensed = true;
                }
                else
                {
                    isVirtualLoveGirlLicensed = true;
                }
                base.OnInspectorGUI();
                return;
            }
            /*
             * ライセンス処理ここまで
             */

            var header1Label = new GUIStyle(EditorStyles.label) { fontStyle = FontStyle.Bold, fontSize = 20, };
            EditorGUILayout.LabelField("三点だいしゅきツール", header1Label, GUILayout.Height(30));

            EditorGUILayout.HelpBox("このコンピュータには三点だいしゅきツールの使用が許諾されていません。Boothのショップから三点だいしゅきツールを購入して、コンピュータにライセンスをインストールしてください。三点だいしゅきツールを購入しているのにこのエラーが表示される場合は、Boothから最新版のZipファイルをダウンロードして、「VirtualLove_Boy.unitypackage」または「VirtualLove_Girl.unitypackage」をインポートしてください。（この作業は１つのパソコンにつき一回行う必要があります）", MessageType.Error);
            if (EditorGUILayout.LinkButton("三点だいしゅきツール(Booth)"))
            {
                Application.OpenURL("https://yunisaki.booth.pm/items/3641334");
            }

        }

        private static string GetLicenseFilePath(string appKey)
        {
#if UNITY_EDITOR_OSX
            string appSupport = System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData);
            return System.IO.Path.Combine(appSupport, "UnisakiStudio", $"{appKey}.lic");
#elif UNITY_EDITOR_LINUX
            string homeDir = System.Environment.GetEnvironmentVariable("HOME");
            return System.IO.Path.Combine(homeDir, ".local", "share", "UnisakiStudio", $"{appKey}.lic");
#else
            return null;
#endif
        }
        
        private static readonly List<string> folderDefines = new()
        {
            "Assets/UnisakiStudio/VirtualLove",
        };

        public static List<string> CheckExistFolderVirtualLove()
        {
            var existFolders = new List<string>();
            foreach (var folderDefine in folderDefines)
            {
                if (AssetDatabase.IsValidFolder(folderDefine))
                {
                    existFolders.Add(folderDefine);
                }
            }
            return existFolders;
        }

    }
}
