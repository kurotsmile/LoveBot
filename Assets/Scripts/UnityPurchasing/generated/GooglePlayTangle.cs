// WARNING: Do not modify! Generated file.

namespace UnityEngine.Purchasing.Security {
    public class GooglePlayTangle
    {
        private static byte[] data = System.Convert.FromBase64String("6iD3/28jNBi/5wlfGys/B8ZO6fvxyDGKmU2bHxNUxMBiVFfjEGpJI9LhHRv5GmSJff6zUBpZxRaewC9VWLIyvi/a+P+e5yi/eGYP3cNZI/tXMrYeo6Lff3ooDS6AFhVwfNo493zH4XqJ9/YfNpld20cr8IDDVIKzsbxRowo3lj/i+3BhZICyAG4PPfyZwpUZCaAtWuVNUHEW3i8Vhlm+jP2o93ukrs6kFle/CCtTVUhB6hscNMb4z7FDt6zfg7etV03WLZKiGcrebO/M3uPo58RopmgZ4+/v7+vu7c0w5hg6VUxgBKy/B75Txdwq2IOqT7IDAQyHbjRnU/9wI3pyFGaNzl5s7+Hu3mzv5Oxs7+/ucQzBR8owNJFNtNqxRCjV2ezt7+7v");
        private static int[] order = new int[] { 13,7,6,10,10,6,8,10,11,9,13,11,12,13,14 };
        private static int key = 238;

        public static readonly bool IsPopulated = true;

        public static byte[] Data() {
        	if (IsPopulated == false)
        		return null;
            return Obfuscator.DeObfuscate(data, order, key);
        }
    }
}
