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
#if UNITY_EDITOR_WIN
using Microsoft.Win32;
#endif
using jp.unisakistudio.posingsystemeditor;

namespace jp.unisakistudio.virtualloveeditor
{
    public class VirtualLoveMenuItems
    {
        private static string GetLicenseFilePath(string appKey)
        {
#if UNITY_EDITOR_OSX
            string appSupport = System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData);
            return Path.Combine(appSupport, "UnisakiStudio", $"{appKey}.lic");
#elif UNITY_EDITOR_LINUX
            string homeDir = System.Environment.GetEnvironmentVariable("HOME");
            return Path.Combine(homeDir, ".local", "share", "UnisakiStudio", $"{appKey}.lic");
#else
            return null;
#endif
        }

        private static bool CheckLicense(string appKey)
        {
#if UNITY_EDITOR_WIN
            try
            {
                var regKey = Registry.CurrentUser.CreateSubKey(VirtualLoveEditor.REGKEY);
                var regValue = (string)regKey.GetValue(appKey);
                if (regValue == "licensed")
                {
                    return true;
                }
            }
            catch (System.Exception)
            {
                // レジストリアクセスに失敗
            }
#endif

#if UNITY_EDITOR_OSX || UNITY_EDITOR_LINUX
            try
            {
                string licenseFilePath = GetLicenseFilePath(appKey);
                if (File.Exists(licenseFilePath))
                {
                    string fileContent = File.ReadAllText(licenseFilePath);
                    if (fileContent == "licensed")
                    {
                        return true;
                    }
                }
            }
            catch (System.Exception)
            {
                // ファイルアクセスに失敗
            }
#endif
            return false;
        }

        [MenuItem("GameObject/ゆにさきスタジオ/三点だいしゅきツール/三点だいしゅきツール(男)追加", false, 22)]
        static public void AddPrefab01() { PosingSystemMenuItems.AddPrefab("三点だいしゅき(男)"); }
        [MenuItem("GameObject/ゆにさきスタジオ/三点だいしゅきツール/三点だいしゅきツール(女)追加", false, 23)]
        static public void AddPrefab02() { PosingSystemMenuItems.AddPrefab("三点だいしゅき(女)"); }
        [MenuItem("GameObject/ゆにさきスタジオ/三点だいしゅきツール/三点だいしゅきツール(男)追加(8bit・足の高さなし)", false, 24)]
        static public void AddPrefab03() { PosingSystemMenuItems.AddPrefab("三点だいしゅき(男)(8bit・足の高さなし)"); }
        [MenuItem("GameObject/ゆにさきスタジオ/三点だいしゅきツール/三点だいしゅきツール(女)追加(8bit・足の高さなし)", false, 25)]
        static public void AddPrefab04() { PosingSystemMenuItems.AddPrefab("三点だいしゅき(女)(8bit・足の高さなし)"); }

        [MenuItem("GameObject/ゆにさきスタジオ/三点だいしゅきツール/三点だいしゅきツール(男)追加", true)]
        [MenuItem("GameObject/ゆにさきスタジオ/三点だいしゅきツール/三点だいしゅきツール(男)追加(8bit・足の高さなし)", true)]
        private static bool ValidateBoy()
        {
            if (!Selection.activeGameObject)
            {
                return false;
            }
            if (!CheckLicense(VirtualLoveEditor.APPKEY_BOY))
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
            if (!CheckLicense(VirtualLoveEditor.APPKEY_GIRL))
            {
                return false;
            }

            var avatar = Selection.activeGameObject.GetComponent<VRCAvatarDescriptor>();
            return avatar != null;
        }
    }
}
