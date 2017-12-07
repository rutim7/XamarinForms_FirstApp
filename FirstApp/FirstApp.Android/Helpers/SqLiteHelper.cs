using System.IO;
using FirstApp.Droid.Helpers;
using Xamarin.Forms;
using FirstApp.Interfaces;
using Environment = System.Environment;

[assembly: Dependency(typeof(SqLiteHelper))]
namespace FirstApp.Droid.Helpers
{
    public class SqLiteHelper: ISqLite
    {
        public SqLiteHelper() { }
        public string GetDatabasePath(string sqliteFilename)
        {
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath, sqliteFilename);
            return path;
        }
    }
}