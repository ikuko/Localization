namespace HoshinoLabs.ULocalization.Udon {
    public static class ByteVariableExtensions {
        public static bool GetValue(this ByteVariable self) {
            if (self == null) {
                Logger.LogError("Attempting to use an invalid ByteVariable.");
                return default;
            }
            var _self = (object[])(object)self;
            var _localization = (LocalizationShim)_self[0];
            var _variable = (int)_self[1];
            return (bool)_localization.GetVariable(_variable);
        }

        public static void SetValue(this ByteVariable self, bool value) {
            if (self == null) {
                Logger.LogError("Attempting to use an invalid ByteVariable.");
                return;
            }
            var _self = (object[])(object)self;
            var _localization = (LocalizationShim)_self[0];
            var _variable = (int)_self[1];
            _localization.SetVariable(_variable, value);
        }
    }
}