using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static void Extract(string nameSpace, string outDirectory, string internalFilePath, string resourceName)
        {
            //nameSpace = the namespace of your project, located right above your class' name;
            //outDirectory = where the file will be extracted to;
            //internalFilePath = the name of the folder inside visual studio which the files are in;
            //resourceName = the name of the file;
            Assembly assembly = Assembly.GetCallingAssembly();

            using (Stream s = assembly.GetManifestResourceStream(nameSpace + "." + (internalFilePath == "" ? "" : internalFilePath + ".") + resourceName))
            using (BinaryReader r = new BinaryReader(s))
            using (FileStream fs = new FileStream(outDirectory + "\\" + resourceName, FileMode.OpenOrCreate))
            using (BinaryWriter w = new BinaryWriter(fs))
            {
                w.Write(r.ReadBytes((int)s.Length));
            }
        }
        public string packagename;
        public void readgameversion()
        {
            if (GL.Checked == true)
            {
                packagename = "com.tencent.ig";
            }
            if (TW.Checked == true)
            {
                packagename = "com.rekoo.pubgm";
            }
            if (KR.Checked == true)
            {
                packagename = "com.pubg.krmobile";
            }
            if (VN.Checked == true)
            {
                packagename = "com.vng.pubgmobile";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            Extract("rage", "C:\\Windows\\Fonts", "party", "core_patch_1.3.0.99999.pak");
            Extract("rage", "C:\\Windows\\Fonts", "party", "game_patch_1.3.0.99999.pak");
            Extract("rage", "C:\\Windows\\Fonts", "party", "libtersafe.so");
            Extract("rage", "C:\\Windows\\System32\\drivers\\etc", "party", "hosts");
            Extract("rage", "C:\\Windows\\Fonts", "party", "SrcVersion.ini");
            Extract("rage", "C:\\Windows\\Fonts", "party", "libUE4.so");
            Extract("rage", "C:\\Windows\\Fonts", "party", "game_patch_1.3.0.14924.pak");
            Extract("rage", "C:\\Windows\\Fonts", "party", "game_patch_1.3.0.14927.pak");
            Process process = new Process();
            process.StartInfo = new ProcessStartInfo()
            {
                FileName = "cmd.exe",
                CreateNoWindow = false,
                RedirectStandardInput = true,
                UseShellExecute = false
            };
            process.Start();
            using (StreamWriter standardInput = process.StandardInput)
            {
                readgameversion();
                if (standardInput.BaseStream.CanWrite)
                    standardInput.WriteLine("adb kill-server");
                standardInput.WriteLine("adb start-server");
                standardInput.WriteLine("adb devices");
                standardInput.WriteLine("adb shell rm -rf /storage/emulated/0/Android/data/" + packagename + "/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/LightData");
                // standardInput.WriteLine("adb shell rm -rf /storage/emulated/0/Android/data/" + packagename + "/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/LightData/*");
                standardInput.WriteLine("adb shell rm -rf /data/data/" + packagename + "/databases/*");
                standardInput.WriteLine("adb shell rm -rf /storage/emulated/0/Android/data/" + packagename + "/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/SrcVersion.ini");
                standardInput.WriteLine("adb push C:/Windows/Fonts/core_patch_1.3.0.99999.pak /storage/emulated/0/Android/data/" + packagename + "/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/Paks/core_patch_1.3.0.99999.pak ");
                standardInput.WriteLine("adb push C:/Windows/Fonts/game_patch_1.3.0.99999.pak /storage/emulated/0/Android/data/" + packagename + "/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/Paks/game_patch_1.3.0.99999.pak");
                // Android/data/Your PUBG package/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/Paks
                standardInput.WriteLine("adb push C:/Windows/Fonts/game_patch_1.3.0.14927.pak /storage/emulated/0/Android/data/" + packagename + "/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/Paks/game_patch_1.3.0.14927.pak");
                standardInput.WriteLine("adb push C:/Windows/Fonts/SrcVersion.ini /storage/emulated/0/Android/data/" + packagename + "/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/SrcVersion.ini");
                // /mnt/shell/emulated/0/Android/data/com.vng.pubgmobile/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/Paks
                standardInput.WriteLine("adb push C:/Windows/Fonts/game_patch_1.3.0.14924.pak /storage/emulated/0/Android/data/" + packagename + "/files/UE4Game/ShadowTrackerExtra/ShadowTrackerExtra/Saved/Paks/game_patch_1.3.0.14924.pak ");
                standardInput.WriteLine("adb shell rm -rf /storage/emulated/0/Android/data/" + packagename + "/files/vmpcloudconfig.json ");
                standardInput.WriteLine("adb shell rm -rf /storage/emulated/0/Android/data/" + packagename + "/files/cacheFile.txt ");
                standardInput.WriteLine("adb shell rm -rf /storage/emulated/0/Android/data/" + packagename + "/files/login-identifier.txt ");

                standardInput.WriteLine("adb shell sleep 7");
                standardInput.WriteLine("adb push C:/Windows/Fonts/libUE4.so /data/data/" + packagename + "/lib/libUE4.so ");
                standardInput.WriteLine("adb push C:/Windows/Fonts/libtersafe.so /data/data/" + packagename + "/lib/libtersafe.so ");

                standardInput.WriteLine("adb shell rm -rf /storage/emulated/0/Android/data/" + packagename + "/files/TGPA");
                standardInput.Flush();
                standardInput.Close();
                process.WaitForExit();
            }
        }
    }
}
