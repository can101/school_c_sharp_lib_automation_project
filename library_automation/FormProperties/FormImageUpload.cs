using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace library_automation.FormProperties
{
    public class FormImageUpload
    {
        public Image File;
        public string fileName;
        OpenFileDialog dlg = new OpenFileDialog();
        public void ImageUpload(PictureBox pictureBox)
        {
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string[] extList = new string[] { ".png", ".gif", ".jpg" };
                // dlg.Filter = "Select image(*.JpG;*.png;*.Gif;)|*.JpG;*.png;*.Gif;";
                File = Image.FromFile(dlg.FileName);
                string ext = Path.GetExtension(dlg.FileName);
                bool extN = extList.Contains(ext);
                if (!extN)
                {
                    MessageBox.Show("Lüfen farkli bir dosya tip ile dneyiniz! ^_^", "Bu bir uyarıdır.", MessageBoxButtons.OK);
                }
                fileName = dlg.SafeFileName;
                pictureBox.Image = Image.FromFile(dlg.FileName);
            }
        }
        public string CreateImageThenReturnUrl(string dirName)
        {
            string path = Directory.GetCurrentDirectory();
            string combinepath = Path.GetFullPath(Path.Combine(path, @"..\..\assets"));
            string newpath = string.Join("\\", combinepath, dirName, fileName);
            File.Save(newpath);
            return newpath;
        }
        public void deleteFile(string filePath)
        {
            FileInfo fileInfo = new FileInfo(filePath);
            fileInfo.Delete();
        }

    }
}
