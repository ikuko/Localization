using HoshinoLabs.Sardinject.Udon;
using System;
using UnityEngine;

namespace HoshinoLabs.ULocalization.Udon {
    [Serializable]
    public sealed class LocalizeSpriteEvent : LocalizeEvent, ISerializable {
        [Inject, SerializeField]
        UnityEngine.Localization.Components.LocalizeSpriteEvent localizeEvent;

        public LocalizeSpriteEvent() {

        }

        public LocalizeSpriteEvent(UnityEngine.Localization.Components.LocalizeSpriteEvent localizeEvent) {
            this.localizeEvent = localizeEvent;
        }

        public void Serialize(IDataWriter writer) {
#if !COMPILER_UDONSHARP && UNITY_EDITOR
            writer.WriteReference("", LocalizationResolver.Resolve());
            writer.WriteInt32("", LocalizeEventCache.AddOrGet(localizeEvent));
#endif
        }

        public void Deserialize(IDataReader reader) {
#if !COMPILER_UDONSHARP && UNITY_EDITOR
            reader.SkipEntry();
            reader.SkipEntry();
#endif
        }
    }
}