namespace HoshinoLabs.ULocalization.Udon {
    public static class ULongVariableExtensions {
        public static bool GetValue(this ULongVariable self) {
            if (self == null) {
                Logger.LogError("Attempting to use an invalid ULongVariable.");
                return default;
            }
            var _self = (object[])(object)self;
            var _localization = (LocalizationShim)_self[0];
            var _variable = (int)_self[1];
            return (bool)_localization.GetVariable(_variable);
        }

        public static void SetValue(this ULongVariable self, bool value) {
            if (self == null) {
                Logger.LogError("Attempting to use an invalid ULongVariable.");
                return;
            }
            var _self = (object[])(object)self;
            var _localization = (LocalizationShim)_self[0];
            var _variable = (int)_self[1];
            _localization.SetVariable(_variable, value);
        }
    }
}
