using UnityEditor;
using jp.unisakistudio.posingsystemeditor;

namespace jp.unisakistudio.virtualloveeditor
{
    // This product's own translations (product name, its pose and menu names and its
    // captions) are generated into Editor/Localization/translations.json from
    // Tools/Localization in this repository. Shared text and the lookup itself belong
    // to the Posing System.
    [InitializeOnLoad]
    internal static class VirtualLoveLocalization
    {
        internal const string CatalogPath = "Packages/jp.unisakistudio.virtuallove/Editor/Localization/translations.json";
        static VirtualLoveLocalization() => PosingSystemLocalization.RegisterProductCatalog(CatalogPath);
    }
}
