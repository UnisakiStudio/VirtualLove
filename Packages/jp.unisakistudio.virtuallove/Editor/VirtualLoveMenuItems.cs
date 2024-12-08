/*
 * VirtualLoveEditor
 * 三点だいしゅきツールの簡易設定用ツール
 * 
 * Copyright(c) 2024 UniSakiStudio
 * Released under the MIT license
 * https://opensource.org/licenses/mit-license.php
 */

using System.Linq;
using UnityEngine;
using UnityEditor;
using VRC.SDK3.Avatars.Components;
using System.IO;
using Microsoft.Win32;

namespace jp.unisakistudio.virtualloveeditor
{
    public class VirtualLoveMenuItems : EditorWindow
    {
        [MenuItem("GameObject/ゆにさきスタジオ/三点だいしゅきツール/三点だいしゅきツール(男)追加", false, 22)]
        static public void AddPrefab01() { AddPrefab("三点だいしゅき(男)"); }
        [MenuItem("GameObject/ゆにさきスタジオ/三点だいしゅきツール/三点だいしゅきツール(女)追加", false, 23)]
        static public void AddPrefab02() { AddPrefab("三点だいしゅき(女)"); }
        [MenuItem("GameObject/ゆにさきスタジオ/三点だいしゅきツール/三点だいしゅきツール(男)追加(8bit・足の高さなし)", false, 24)]
        static public void AddPrefab03() { AddPrefab("三点だいしゅき(男)(8bit・足の高さなし)"); }
        [MenuItem("GameObject/ゆにさきスタジオ/三点だいしゅきツール/三点だいしゅきツール(女)追加(8bit・足の高さなし)", false, 25)]
        static public void AddPrefab04() { AddPrefab("三点だいしゅき(女)(8bit・足の高さなし)"); }

        static public void AddPrefab(string name)
        {
            if (Selection.activeGameObject)
            {
                var avatar = Selection.activeGameObject.GetComponent<VRCAvatarDescriptor>();

                var guids = AssetDatabase.FindAssets("t:prefab " + name)
                    .Select(AssetDatabase.GUIDToAssetPath)
                    .Where(path => string.Equals(Path.GetFileNameWithoutExtension(path), name, System.StringComparison.CurrentCulture));
                if (guids.Count() == 0)
                {
                    EditorUtility.DisplayDialog("エラー", "Prefabsが見つかりません。ツールを再度インポートしなおしてください", "閉じる");
                    return;
                }

                var prefabs = AssetDatabase.LoadAssetAtPath<GameObject>(guids.First());

                PrefabUtility.InstantiatePrefab(prefabs, avatar.transform);
            }
       }

        [MenuItem("GameObject/ゆにさきスタジオ/三点だいしゅきツール/三点だいしゅきツール(男)追加", true)]
        [MenuItem("GameObject/ゆにさきスタジオ/三点だいしゅきツール/三点だいしゅきツール(男)追加(8bit・足の高さなし)", true)]
        private static bool ValidateBoy()
        {
            if (!Selection.activeGameObject)
            {
                return false;
            }
            var regKey = Registry.CurrentUser.CreateSubKey(VirtualLoveEditor.REGKEY);
            var regValueBoy = (string)regKey.GetValue(VirtualLoveEditor.APPKEY_BOY);
            if (regValueBoy != "licensed")
            {
                return false;
            }
            
            var avatar = Selection.activeGameObject.GetComponent<VRCAvatarDescriptor>();
            return avatar != null;
        }

        [MenuItem("GameObject/ゆにさきスタジオ/三点だいしゅきツール/三点だいしゅきツール(女)追加", true)]
        [MenuItem("GameObject/ゆにさきスタジオ/三点だいしゅきツール/三点だいしゅきツール(女)追加(8bit・足の高さなし)", true)]
        private static bool ValidateGirl()
        {
            if (!Selection.activeGameObject)
            {
                return false;
            }
            var regKey = Registry.CurrentUser.CreateSubKey(VirtualLoveEditor.REGKEY);
            var regValueGirl = (string)regKey.GetValue(VirtualLoveEditor.APPKEY_GIRL);
            if (regValueGirl != "licensed")
            {
                return false;
            }

            var avatar = Selection.activeGameObject.GetComponent<VRCAvatarDescriptor>();
            return avatar != null;
        }
    }
}
