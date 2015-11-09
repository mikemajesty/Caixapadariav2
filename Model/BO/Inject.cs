using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model.BO
{
    public static class Inject
    {
        public static string GetFullPath(this string arquivoComExtensao)
        {
           return  Directory.GetFiles(System.IO.Path.GetDirectoryName(Path.GetDirectoryName(Application.StartupPath)), arquivoComExtensao, SearchOption.AllDirectories).FirstOrDefault();
        }
    }
}
