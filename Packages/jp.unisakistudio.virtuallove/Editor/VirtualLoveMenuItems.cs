/*
 * VirtualLoveEditor
 * 三点だいしゅきツールの簡易設定用ツール
 * 
 * Copyright(c) 2024 UniSakiStudio
 * Released under the MIT license
 * https://opensource.org/licenses/mit-license.php
 */

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
    public static class VirtualLoveMenuItems
    {
        private const string REGKEY = @"SOFTWARE\UnisakiStudio";
        private const string APPKEY_BOY = "virtuallove_boy";
        private const string APPKEY_GIRL = "virtuallove_girl";
        private const string LICENSE_VALUE = "licensed";

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
            if (!IsLicensed(APPKEY_BOY))
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
            if (!IsLicensed(APPKEY_GIRL))
            {
                return false;
            }

            var avatar = Selection.activeGameObject.GetComponent<VRCAvatarDescriptor>();
            return avatar != null;
        }

        // ========================================
        // ライセンス関連
        // ========================================
        
        /// <summary>
        /// 男の子用のライセンスがインストールされているかチェック
        /// </summary>
        public static bool IsLicensedBoy()
        {
            return IsLicensed(APPKEY_BOY);
        }
        
        /// <summary>
        /// 女の子用のライセンスがインストールされているかチェック
        /// </summary>
        public static bool IsLicensedGirl()
        {
            return IsLicensed(APPKEY_GIRL);
        }
        
        /// <summary>
        /// Mac/Linux用の設定ファイルパス
        /// </summary>
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
        
        /// <summary>
        /// ライセンスがインストールされているかチェック
        /// </summary>
        private static bool IsLicensed(string appKey)
        {
#if UNITY_EDITOR_WIN
            try
            {
                var regKey = Registry.CurrentUser.OpenSubKey(REGKEY);
                if (regKey != null)
                {
                    var value = (string)regKey.GetValue(appKey);
                    regKey.Close();
                    return value == LICENSE_VALUE;
                }
            }
            catch (System.Exception)
            {
                // 例外は無視
            }
            return false;
#elif UNITY_EDITOR_OSX || UNITY_EDITOR_LINUX
            try
            {
                string licenseFilePath = GetLicenseFilePath(appKey);
                if (File.Exists(licenseFilePath))
                {
                    string fileContent = File.ReadAllText(licenseFilePath);
                    return fileContent == LICENSE_VALUE;
                }
            }
            catch (System.Exception)
            {
                // 例外は無視
            }
            return false;
#else
            return false;
#endif
        }
        
        /// <summary>
        /// ライセンスを削除（男の子用）
        /// </summary>
        [MenuItem("Tools/ゆにさきスタジオ/三点だいしゅきツール(男)ライセンス削除", false, 201)]
        public static void UninstallLicenseBoy()
        {
            UninstallLicense(APPKEY_BOY, "三点だいしゅきツール（男の子用）");
        }
        
        /// <summary>
        /// ライセンスを削除（女の子用）
        /// </summary>
        [MenuItem("Tools/ゆにさきスタジオ/三点だいしゅきツール(女)ライセンス削除", false, 202)]
        public static void UninstallLicenseGirl()
        {
            UninstallLicense(APPKEY_GIRL, "三点だいしゅきツール（女の子用）");
        }
        
        private static void UninstallLicense(string appKey, string productName)
        {
            if (!IsLicensed(appKey))
            {
                EditorUtility.DisplayDialog(
                    "ライセンスの削除",
                    $"{productName}のライセンスはインストールされていません。",
                    "OK"
                );
                return;
            }
            
            bool shouldUninstall = EditorUtility.DisplayDialog(
                "ライセンス削除",
                $"{productName}のライセンスを削除しますか？\n\n" +
                "削除すると、ツールの機能が制限されます。\n" +
                "再度ライセンスを有効化するには、ライセンスインストーラーを再インポートする必要があります。",
                "削除",
                "キャンセル"
            );
            
            if (!shouldUninstall)
            {
                return;
            }
            
            string resultMessage = "";
            
#if UNITY_EDITOR_WIN
            try
            {
                var regKey = Registry.CurrentUser.OpenSubKey(REGKEY, true);
                if (regKey != null)
                {
                    // ライセンスを削除
                    try
                    {
                        regKey.DeleteValue(appKey, false);
                    }
                    catch (System.Exception) { }
                    
                    // レジストリキーが空になった場合は削除
                    if (regKey.ValueCount == 0 && regKey.SubKeyCount == 0)
                    {
                        regKey.Close();
                        Registry.CurrentUser.DeleteSubKey(REGKEY, false);
                        resultMessage = $"{productName}のライセンスを削除しました。";
                    }
                    else
                    {
                        regKey.Close();
                        resultMessage = $"{productName}のライセンスを削除しました。\n（他のゆにさきスタジオ商品のライセンスは保持されます）";
                    }
                    
                    Debug.Log($"[VirtualLove] {resultMessage}");
                }
                else
                {
                    resultMessage = "ライセンス情報は見つかりませんでした。";
                }
            }
            catch (System.Exception ex)
            {
                resultMessage = $"ライセンスの削除に失敗しました: {ex.Message}";
                Debug.LogError($"[VirtualLove] {resultMessage}");
            }
#endif
            
#if UNITY_EDITOR_OSX || UNITY_EDITOR_LINUX
            try
            {
                string licenseFilePath = GetLicenseFilePath(appKey);
                
                // ライセンスファイルを削除
                if (File.Exists(licenseFilePath))
                {
                    File.Delete(licenseFilePath);
                    
                    // ディレクトリが空になった場合は削除
                    string directoryPath = Path.GetDirectoryName(licenseFilePath);
                    if (Directory.Exists(directoryPath) && 
                        Directory.GetFiles(directoryPath).Length == 0 && 
                        Directory.GetDirectories(directoryPath).Length == 0)
                    {
                        Directory.Delete(directoryPath);
                        resultMessage = $"{productName}のライセンスを削除しました。";
                    }
                    else
                    {
                        resultMessage = $"{productName}のライセンスを削除しました。\n（他のゆにさきスタジオ商品のライセンスは保持されます）";
                    }
                    
                    Debug.Log($"[VirtualLove] {resultMessage}");
                }
                else
                {
                    resultMessage = "ライセンス情報は見つかりませんでした。";
                }
            }
            catch (System.Exception ex)
            {
                resultMessage = $"ライセンスの削除に失敗しました: {ex.Message}";
                Debug.LogError($"[VirtualLove] {resultMessage}");
            }
#endif
            
            EditorUtility.DisplayDialog(
                "ライセンス削除",
                resultMessage,
                "OK"
            );
        }
    }
}
