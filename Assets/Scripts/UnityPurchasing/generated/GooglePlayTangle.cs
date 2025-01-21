// WARNING: Do not modify! Generated file.

namespace UnityEngine.Purchasing.Security {
    public class GooglePlayTangle
    {
        private static byte[] data = System.Convert.FromBase64String("CLo5Ggg1PjESvnC+zzU5OTk9ODsEN8vNL8yyX6soZYbMjxPASBb5gyt+Ia1yeBhywIFp3v2Fg56XPM3KqhE3rF8hIMngT4sNkf0mVhWCVGWZZNXX2lG44rGFKab1rKTCsFsYiGdqh3Xc4UDpNC2mt7JWZNa42esqPPYhKbn14s5pMd+Jzf3p0RCYPy26OTc4CLo5Mjq6OTk4p9oXkRzm4k8UQ8/fdvuMM5uGp8AI+cNQj2haG+YwzuyDmrbSemnRaIUTCvwOVXyB5GDIdXQJqaz+2/hWwMOmqgzuIeIQLhlnlWF6CVVhe4GbAPtEdM8cjmTkaPkMLilIMf5prrDZCxWP9S0nHudcT5tNycWCEha0goE1xryf9UebYgxnkv4DDzo7OTg5");
        private static int[] order = new int[] { 0,6,11,11,12,8,13,13,12,12,11,12,12,13,14 };
        private static int key = 56;

        public static readonly bool IsPopulated = true;

        public static byte[] Data() {
        	if (IsPopulated == false)
        		return null;
            return Obfuscator.DeObfuscate(data, order, key);
        }
    }
}
