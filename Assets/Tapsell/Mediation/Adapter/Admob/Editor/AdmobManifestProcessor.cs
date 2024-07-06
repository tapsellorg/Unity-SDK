#if UNITY_ANDROID

using Tapsell.Mediation.Editor;
using Tapsell.Mediation.Editor.Utils;

namespace Tapsell.Mediation.Adapter.Admob.Editor
{
    internal class AdmobManifestProcessor : ManifestProcessor
    {
        private protected override string PluginName()
        {
            return "TapsellMediationAdmobAdapter";
        }

        private protected override string ManifestRelativePath()
        {
#if UNITY_2021_2_OR_NEWER
            return "Plugins/Android/TapsellMediationAdmobAdapterPlugin/AndroidManifest.xml";
#else
            return "Plugins/Android/AndroidManifest.xml";       
#endif
        }

        private protected override string MetadataApplicationKey()
        {
            return "com.google.android.gms.ads.APPLICATION_ID";
        }

        private protected override string MetadataApplicationValue()
        {
            return TapsellMediationSettings.LoadInstance().AdmobAdapterSignature;
        }

        private protected override bool ShouldValidateMetadataApplicationValue()
        {
            return false;
        }

        public override int callbackOrder => 1;
    }
}

#endif