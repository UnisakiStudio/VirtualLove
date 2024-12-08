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

        public override void OnInspectorGUI()
        {
            VirtualLove virtualLove = target as VirtualLove;

            /*
             * このコメント分を含むここから先の処理は三点だいしゅきツールをゆにさきスタジオから購入した場合に変更することを許可します。
             * つまり購入者はライセンスにまつわるこの先のソースコードを削除して再配布を行うことができます。
             * 逆に、購入をせずにGithubなどからソースコードを取得しただけの場合、このライセンスに関するソースコードに手を加えることは許可しません。
             */
            if (virtualLove.isBoy && virtualLove.isVirtualLoveBoyLicensed)
            {
                base.OnInspectorGUI();
                return;
            }
            if (!virtualLove.isBoy && virtualLove.isVirtualLoveGirlLicensed)
            {
                base.OnInspectorGUI();
                return;
            }

            var regKey = Registry.CurrentUser.CreateSubKey(REGKEY);

            var regValueBoy = (string)regKey.GetValue(APPKEY_BOY);
            if (regValueBoy == "licensed")
            {
                virtualLove.isVirtualLoveBoyLicensed = true;
            }

            var regValueGirl = (string)regKey.GetValue(APPKEY_GIRL);
            if (regValueGirl == "licensed")
            {
                virtualLove.isVirtualLoveGirlLicensed = true;
            }

            if (virtualLove.isBoy && virtualLove.isVirtualLoveBoyLicensed)
            {
                base.OnInspectorGUI();
                return;
            }
            if (!virtualLove.isBoy && virtualLove.isVirtualLoveGirlLicensed)
            {
                base.OnInspectorGUI();
                return;
            }
            /*
             * ライセンス処理ここまで
             */

            EditorGUILayout.LabelField("三点だいしゅきツール", new GUIStyle() { fontStyle = FontStyle.Bold, fontSize = 20, }, GUILayout.Height(30));

            EditorGUILayout.HelpBox("このコンピュータには三点だいしゅきツールの使用が許諾されていません。Boothのショップから三点だいしゅきツールを購入して、コンピュータにライセンスをインストールしてください", MessageType.Error);
            if (EditorGUILayout.LinkButton("三点だいしゅきツール(Booth)"))
            {
                Application.OpenURL("https://yunisaki.booth.pm/items/3641334");
            }

        }

        private readonly List<string> folderDefines = new()
        {
            "Assets/UnisakiStudio/VirtualLove",
        };

        override protected List<string> CheckExistFolder()
        {
            List<string> existFolders = base.CheckExistFolder();
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
