using System.IO;
using Windows.Storage;
using TodoList.UWP;
using Xamarin.Forms;

[assembly: Dependency(typeof(FileHelper))]
namespace TodoList.UWP
{
    public class FileHelper: IFileHelper
    {
        public string GetLocalFilePath(string filename)
        {
            return Path.Combine(ApplicationData.Current.LocalFolder.Path, filename);
        }
    }
}
