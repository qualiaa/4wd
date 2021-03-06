// <auto-generated>
// Rewired Constants
// This list was generated on 20/10/2017 21:06:57
// The list applies to only the Rewired Input Manager from which it was generated.
// If you use a different Rewired Input Manager, you will have to generate a new list.
// If you make changes to the exported items in the Rewired Input Manager, you will
// need to regenerate this list.
// </auto-generated>

namespace RewiredConsts {
    public static partial class Action {
        // Default
        [Rewired.Dev.ActionIdFieldInfo(categoryName = "Default", friendlyName = "Steer")]
        public const int Steer = 0;
        [Rewired.Dev.ActionIdFieldInfo(categoryName = "Default", friendlyName = "Accelerate, break or reverse")]
        public const int Gas = 1;
        [Rewired.Dev.ActionIdFieldInfo(categoryName = "Default", friendlyName = "LightSwitch")]
        public const int LightSwitch = 3;
        [Rewired.Dev.ActionIdFieldInfo(categoryName = "Default", friendlyName = "Honk")]
        public const int Honk = 4;
    }
    public static partial class Category {
        public const int Default = 0;
    }
    public static partial class Layout {
        public static partial class Joystick {
            public const int Default = 0;
        }
        public static partial class Keyboard {
            public const int Default = 0;
            public const int tfgh = 3;
            public const int ijkl = 2;
            public const int Arrows = 1;
        }
        public static partial class Mouse {
            public const int Default = 0;
        }
        public static partial class CustomController {
            public const int Default = 0;
        }
    }
    public static partial class Player {
        [Rewired.Dev.PlayerIdFieldInfo(friendlyName = "System")]
        public const int System = 9999999;
        [Rewired.Dev.PlayerIdFieldInfo(friendlyName = "Player0")]
        public const int Player0 = 0;
        [Rewired.Dev.PlayerIdFieldInfo(friendlyName = "Player1")]
        public const int Player1 = 1;
        [Rewired.Dev.PlayerIdFieldInfo(friendlyName = "Player2")]
        public const int Player2 = 2;
        [Rewired.Dev.PlayerIdFieldInfo(friendlyName = "Player3")]
        public const int Player3 = 3;
    }
    public static partial class CustomController {
    }
}
